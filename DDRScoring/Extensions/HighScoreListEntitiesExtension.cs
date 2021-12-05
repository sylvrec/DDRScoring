using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Extensions
{
    public static class HighScoreListEntitiesExtension
    {
        public static IEnumerable<HighScoreList> Except(this IList<HighScoreList> first, IList<HighScoreList> second)
        {
            foreach (var highScoreList in first)
            {
                if (!second.Where(x => x.LastPlayed == highScoreList.LastPlayed).Any())
                {
                    yield return highScoreList;
                }
            }
        }

        public static IList<HighScoreList> MergeKey(this IList<HighScoreList> first, IList<HighScoreList> second)
        {
            List<HighScoreList> result = first.ToList();

            result.ForEach(c => {
                var s = second.Where(x => x.LastPlayed == c.LastPlayed)?.FirstOrDefault();
                if (s != null) c.Id = s.Id;
            });
            return result;
        }
    }
}
