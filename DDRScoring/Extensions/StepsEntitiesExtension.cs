using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Extensions
{
    public static class StepsEntitiesExtension
    {
        public static IEnumerable<Steps> Except(this IList<Steps> first, IList<Steps> second)
        {
            foreach (var step in first)
            {
                if (!second.Where(x => x.Difficulty == step.Difficulty &&
                                       x.StepsType == step.StepsType).Any())
                {
                   yield return step;
                }
            }
        }

        public static IList<Steps> MergeKey(this IList<Steps> first, IList<Steps> second)
        {
            List<Steps> result = first.ToList();

            result.ForEach(c => {
                var s = second.Where(x => x.Difficulty == c.Difficulty && x.StepsType == c.StepsType)?.FirstOrDefault();
                if (s != null)
                {
                    c.Id = s.Id;
                    c.SongId = s.SongId;
                    c.HighScoreListId = s.HighScoreListId;
                }
            });
            return result;
        }
    }
}
