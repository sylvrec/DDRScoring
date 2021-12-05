using DDRScoring.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Services.Impl
{
    public class DTOService : IDTOService
    {
        private readonly Stats _stats;

        public DTOService(Stats stats)
        {
            _stats = stats;
        }

        public List<Song> StatsToGetSongs()
        {
            if (_stats != null && _stats.SongScores != null && _stats.SongScores.Song != null)
                return _stats.SongScores.Song;
            return new List<Song>();
        }

        public List<Steps> StatsToGetSteps()
        {
            List<Steps> steps = new List<Steps>();

            if (_stats != null && _stats.SongScores != null && _stats.SongScores.Song != null)
                _stats.SongScores.Song.ForEach(s => steps.AddRange(s.Steps));
            return steps;
        }

        public List<HighScoreList> StatsToGetHighScoreList()
        {
            List<HighScoreList> highScoreLists = new List<HighScoreList>();

            var steps = StatsToGetSteps();
            steps.ForEach(s => highScoreLists.Add(s.HighScoreList));
            return highScoreLists;
        }

        public List<HighScore> StatsToGetHighScore()
        {
            List<HighScore> highScore = new List<HighScore>();

            var highScoreList = StatsToGetHighScoreList();
            highScoreList.ForEach(s => highScore.AddRange(s.HighScore));
            return highScore;
        }

        public List<TapNoteScores> StatsToGetTapNoteScores()
        {
            List<TapNoteScores> tapNoteScores = new List<TapNoteScores>();

            var highScore = StatsToGetHighScore();
            highScore.ForEach(s => tapNoteScores.Add(s.TapNoteScores));
            return tapNoteScores;
        }

        public List<HoldNoteScores> StatsToGetHoldNoteScores()
        {
            List<HoldNoteScores> holdNoteScores = new List<HoldNoteScores>();

            var highScore = StatsToGetHighScore();
            highScore.ForEach(s => holdNoteScores.Add(s.HoldNoteScores));
            return holdNoteScores;
        }

        public List<RadarValues> StatsToGetRadarValues()
        {
            List<RadarValues> radarValues = new List<RadarValues>();

            var highScore = StatsToGetHighScore();
            highScore.ForEach(s => radarValues.Add(s.RadarValues));
            return radarValues;
        }
    }
}
