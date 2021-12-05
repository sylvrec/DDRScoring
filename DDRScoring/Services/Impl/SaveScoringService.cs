using AutoMapper;
using DDRScoring.Data.DTO;
using DDRScoring.Data.Entities;
using DDRScoring.Data.Repository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DDRScoring.Extensions;
using DDRScoring.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DDRScoring.Services.Impl
{
    public class SaveScoringService : ISaveScoringService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly ISongRepository _songRepository;
        private readonly IStepsRepository _stepsRepository;
        private readonly IHighScoreListRepository _highScoreListRepository;
        private readonly IHighScoreRepository _highScoreRepository;
        private readonly ITapNoteScoresRepository _tapNoteScoresRepository;
        private readonly IHoldNoteScoresRepository _holdNoteScoresRepository;
        private readonly IRadarValuesRepository _radarValuesRepository;
        private readonly ICaloriesBurnedRepository _caloriesBurnedRepository;
        private readonly DDRScoringContext _context;
        private readonly ILogger<SaveScoringService> _logger;
        private readonly IMapper _mapper;

        public SaveScoringService(IPlayerRepository playerRepository,
                                  ISongRepository songRepository,
                                  IStepsRepository stepsRepository,
                                  IHighScoreListRepository highScoreListRepository,
                                  IHighScoreRepository highScoreRepository,
                                  ITapNoteScoresRepository tapNoteScoresRepository,
                                  IHoldNoteScoresRepository holdNoteScoresRepository,
                                  IRadarValuesRepository radarValuesRepository,
                                  ICaloriesBurnedRepository caloriesBurnedRepository,
                                  DDRScoringContext context,
                                  ILogger<SaveScoringService> logger,
                                  IMapper mapper)
        {
            _playerRepository = playerRepository;
            _songRepository = songRepository;
            _stepsRepository = stepsRepository;
            _highScoreListRepository = highScoreListRepository;
            _highScoreRepository = highScoreRepository;
            _tapNoteScoresRepository = tapNoteScoresRepository;
            _holdNoteScoresRepository = holdNoteScoresRepository;
            _radarValuesRepository = radarValuesRepository;
            _caloriesBurnedRepository = caloriesBurnedRepository;
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<int> SaveAndMergeAsync(ClaimsPrincipal userAuthentified, Stats stats)
        {

            var dtoService = new DTOService(stats);

            Player player = new();
            var countScore = 0;
            player = await _playerRepository.GetPlayerAuthentifiedAsync(userAuthentified);

            var songs = _mapper.Map<IList<Data.DTO.Song>, IList<Data.Entities.Song>>(dtoService.StatsToGetSongs()).ToList();
            var actualSongs = _songRepository.SongByPlayer(player);
            _songRepository.AddRange(songs.Except(actualSongs));

            var actualStep = _stepsRepository.StepsBySongs(actualSongs);
            var newSteps = _mapper.Map<IList<Data.DTO.Steps>, IList<Data.Entities.Steps>>(dtoService.StatsToGetSteps()).ToList();
            _stepsRepository.AddRange(newSteps.Except(actualStep));

            var actualHighScoreList = _highScoreListRepository.HighScoresListBySteps(actualStep);
            var newHighScoreList = _mapper.Map<IList<Data.DTO.HighScoreList>, IList<Data.Entities.HighScoreList>>(dtoService.StatsToGetHighScoreList());
            _highScoreListRepository.AddRange(newHighScoreList.Except(actualHighScoreList));

            var actualHighScore = _highScoreRepository.HighScoresByHighScoreList(actualHighScoreList);
            var newHighScore = _mapper.Map<IList<Data.DTO.HighScore>, IList<Data.Entities.HighScore>>(dtoService.StatsToGetHighScore());
            _highScoreRepository.AddRange(newHighScore.Except(actualHighScore));

            var actualTapNoteScores = _tapNoteScoresRepository.TapNoteScoresByHighScore(actualHighScore);
            var newTapNoteScores = _mapper.Map<IList<Data.DTO.TapNoteScores>, IList<Data.Entities.TapNoteScores>>(dtoService.StatsToGetTapNoteScores());
            _tapNoteScoresRepository.AddRange(newTapNoteScores.Except(actualTapNoteScores));

            var actualHoldNoteScores = _holdNoteScoresRepository.HoldNoteScoresByHighScore(actualHighScore);
            var newHoldNoteScores = _mapper.Map<IList<Data.DTO.HoldNoteScores>, IList<Data.Entities.HoldNoteScores>>(dtoService.StatsToGetHoldNoteScores());            
            _holdNoteScoresRepository.AddRange(newHoldNoteScores.Except(actualHoldNoteScores));

            var actualRadarValues = _radarValuesRepository.RadarValuesByHighScore(newHighScore);
            var newRadarValues = _mapper.Map<IList<Data.DTO.RadarValues>, IList<Data.Entities.RadarValues>>(dtoService.StatsToGetRadarValues());
            _radarValuesRepository.AddRange(newRadarValues.Except(actualRadarValues));

            var actualCaloriesBurned = _caloriesBurnedRepository.CaloriesBurnedByPlayer(player);
            var newCaloriesBurned = _mapper.Map<IList<Data.DTO.CaloriesBurned>, IList<Data.Entities.CaloriesBurned>>(stats.CalorieData.CaloriesBurned);
            _caloriesBurnedRepository.AddRange(newCaloriesBurned.Except(actualCaloriesBurned));

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex.InnerException.Message);
            }
            return countScore;
        }
    }
}
