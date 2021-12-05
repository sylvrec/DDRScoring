using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class StepsRepository : DDRScoringRepository<Steps>, IStepsRepository
    {
        public StepsRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public IList<Steps> StepsBySongs(IList<Song> songs)
        {
            List<Steps> list = new();

            foreach (var song in songs)
            {
                var steps = _context.Steps.Where(x => x.SongId == song.Id);
                if (steps != null && steps.Count() > 0)
                    list.AddRange(steps);
            }
            return list;
        }
    }
}
