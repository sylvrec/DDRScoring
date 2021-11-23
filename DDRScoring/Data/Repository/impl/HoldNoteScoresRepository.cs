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
    }
}
