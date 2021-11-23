using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class SongRepository : DDRScoringRepository<Song>, ISongRepository
    {
        public SongRepository(DDRScoringContext context)
            : base(context)
        {
        }
    }
}
