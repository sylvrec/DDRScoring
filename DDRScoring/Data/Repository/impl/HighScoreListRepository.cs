using DDRScoring.Data.Entities;
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
    }
}
