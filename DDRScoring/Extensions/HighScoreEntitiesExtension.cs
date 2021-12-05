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
    }
}
