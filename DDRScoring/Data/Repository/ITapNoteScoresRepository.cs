using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository
{
    public interface ITapNoteScoresRepository : IDDRScoringRepository<TapNoteScores>
    {
        IList<TapNoteScores> TapNoteScoresByHighScore(IList<HighScore> highScores);
    }
}
