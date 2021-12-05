using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDRScoring.Data.Entities;

namespace DDRScoring.Extensions
{
    public static class HighScoreEntitiesExtension
    {
        public static IEnumerable<HighScore> Except(this List<HighScore> first, List<HighScore> second)
        {
            foreach (var highScore in first)
            {
                if (!second.Where(x => x.DateTime == highScore.DateTime).Any())
                {
                    yield return highScore;
                }
            }
        }
        public static IList<HighScore> MergeKey(this IList<HighScore> first, IList<HighScore> second)
        {
            List<HighScore> result = first.ToList();

            result.ForEach(c => {
                var s = second.Where(x => x.DateTime == c.DateTime)?.FirstOrDefault();
                if (s != null)
                {
                    c.Id = s.Id;
                    c.HighScoreListId = s.HighScoreListId;
                    c.TapNoteScoresId = s.TapNoteScoresId;
                    c.RadarValuesId = s.RadarValuesId;
                }
            });
            return result;
        }
    }
}
