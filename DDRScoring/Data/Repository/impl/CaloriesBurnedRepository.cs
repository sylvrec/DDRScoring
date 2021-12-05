using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class CaloriesBurnedRepository : DDRScoringRepository<CaloriesBurned>, ICaloriesBurnedRepository
    {
        public CaloriesBurnedRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public IList<CaloriesBurned> CaloriesBurnedByPlayer(Player player)
        {
            return _context.CaloriesBurned.Where(x => x.PlayerId == player.Id).ToList();
        }
    }
}
