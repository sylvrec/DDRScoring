using DDRScoring.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class HighScoreListRepository : DDRScoringRepository<HighScoreList>, IHighScoreListRepository
    {
        public HighScoreListRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public IList<HighScoreList> HighScoresListBySteps(IList<Steps> steps)
        {
            List<HighScoreList> list = new List<HighScoreList>();
            
            foreach (var step in steps)
            {
                var highScoreList = _context.HighScoreList.Where(x => x.Id == step.HighScoreListId).ToList();
                if (highScoreList != null && highScoreList.Count > 0)
                    list.AddRange(highScoreList);
            }
            return list;
        }

        public IList<HighScore> HighScoreByPlayerAndSong(Player player, Song song)
        {
            //return _context.Song.Where(x => x.PlayerId == player.Id &&
            //                                 x.Id == song.Id)
            //        .Include(x => x.Steps)
            //            .ThenInclude(step => step.HighScoreList)
            //                .ThenInclude(highScoreList => highScoreList.HighScore)
            //                .SelectMany(s => s.Steps.SelectMany(step => step.HighScoreList.HighScore))
            //        .ToList();
            return _context.HighScore.Where(highScore => highScore.HighScoreList.Steps.Song.PlayerId == player.Id &&
                                            highScore.HighScoreList.Steps.Song.Id == song.Id).ToList();
        }
    }
}
