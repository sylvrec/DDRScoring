using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class TapNoteScoresRepository : DDRScoringRepository<TapNoteScores>, ITapNoteScoresRepository
    {
        public TapNoteScoresRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public IList<TapNoteScores> TapNoteScoresByHighScore(IList<HighScore> highScores)
        {
            List<TapNoteScores> list = new List<TapNoteScores>();

            foreach (var highScore in highScores)
            {
                var tapNoteScores = _context.TapNoteScores.Where(x => x.Id == highScore.TapNoteScoresId).FirstOrDefault();
                if (tapNoteScores != null)
                    list.Add(tapNoteScores);
            }
            return list;
        }
    }
}
