using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class HighScoreRepository : DDRScoringRepository<HighScore>, IHighScoreRepository
    {
        public HighScoreRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public IList<HighScore> HighScoresByHighScoreList(IList<HighScoreList> highScoreLists)
        {
            List<HighScore> list = new List<HighScore>();

            foreach (var highScoreList in highScoreLists)
            {
                var highScores = _context.HighScore.Where(x => x.HighScoreListId == highScoreList.Id).ToList();
                if (highScores != null)
                    list.AddRange(highScores);
            }
            return list;
        }
    }
}
