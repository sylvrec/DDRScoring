using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class HoldNoteScoresRepository : DDRScoringRepository<HoldNoteScores>, IHoldNoteScoresRepository
    {
        public HoldNoteScoresRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public IList<HoldNoteScores> HoldNoteScoresByHighScore(IList<HighScore> highScores)
        {
            List<HoldNoteScores> list = new List<HoldNoteScores>();

            foreach (var highScore in highScores)
            {
                var holdNoteScores = _context.HoldNoteScores.Where(x => x.Id == highScore.HoldNoteScoreId).FirstOrDefault();
                if (holdNoteScores != null)
                    list.Add(holdNoteScores);
            }
            return list;
        }
    }
}
