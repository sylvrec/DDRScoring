using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Extensions
{
    public static class CaloriesBurnedRepository
    {
        public static IEnumerable<CaloriesBurned> Except(this IList<CaloriesBurned> first, IList<CaloriesBurned> second)
        {
            foreach (var caloriesBurned in first)
            {
                if (!second.Where(x => x.Date == caloriesBurned.Date &&
                                       x.Text == caloriesBurned.Text).Any())
                {
                    yield return caloriesBurned;
                }
            }
        }

        public static IList<CaloriesBurned> MergeKey(this IList<CaloriesBurned> first, IList<CaloriesBurned> second)
        {
            List<CaloriesBurned> result = first.ToList();

            result.ForEach(c => {
                var s = second.Where(x => x.Date == c.Date && x.Text == c.Text)?.FirstOrDefault();
                if (s != null)
                {
                    c.Id = s.Id;
                    c.PlayerId = s.PlayerId;
                }
            });
            return result;
        }
    }
}
