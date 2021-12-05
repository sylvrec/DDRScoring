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
    }
}
