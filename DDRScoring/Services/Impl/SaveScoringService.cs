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
        private readonly DDRScoringContext _context;
        private readonly ILogger<SaveScoringService> _logger;
        private readonly IMapper _mapper;

        public SaveScoringService(
                                  IPlayerRepository playerRepository,
                                  DDRScoringContext context,
                                  ILogger<SaveScoringService> logger,
                                  IMapper mapper)
        {
            _playerRepository = playerRepository;
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<int> SaveAndMergeAsync(Player newPlayer)
        {
            try
            {
                Player player = await _playerRepository.GetPlayerAuthentifiedAsync(userAuthentified);
                _playerRepository.Remove(player);
                _playerRepository.Add(newPlayer);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex.InnerException.Message);
                return -1;
            }
            return 0;
        }
    }
}
