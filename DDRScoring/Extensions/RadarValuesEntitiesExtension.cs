using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Extensions
{
    public static class RadarValuesEntitiesExtension
    {
        public static IEnumerable<RadarValues> Except(this IList<RadarValues> first, IList<RadarValues> second)
        {
            foreach (var radarValue in first)
            {
                if (!second.Where(x => x.Air == radarValue.Air &&
                                          x.Chaos == radarValue.Chaos &&
                                          x.Fakes == radarValue.Fakes &&
                                          x.Freeze == radarValue.Freeze &&
                                          x.Hands == radarValue.Hands &&
                                          x.Holds == radarValue.Holds &&
                                          x.Jumps == radarValue.Jumps &&
                                          x.Lifts == radarValue.Lifts &&
                                          x.Mines == radarValue.Mines &&
                                          x.Notes == radarValue.Notes &&
                                          x.Rolls == radarValue.Rolls &&
                                          x.Stream == radarValue.Stream &&
                                          x.TapsAndHolds == radarValue.TapsAndHolds &&
                                          x.Voltage == radarValue.Voltage).Any())
                {
                    yield return radarValue;
                }
            }
        }

        public static IList<RadarValues> MergeKey(this IList<RadarValues> first, IList<RadarValues> second)
        {
            List<RadarValues> result = first.ToList();

            result.ForEach(c =>
            {
                var s = second.Where(x => x.Air == c.Air &&
                                          x.Chaos == c.Chaos &&
                                          x.Fakes == c.Fakes &&
                                          x.Freeze == c.Freeze &&
                                          x.Hands == c.Hands &&
                                          x.Holds == c.Holds &&
                                          x.Jumps == c.Jumps &&
                                          x.Lifts == c.Lifts &&
                                          x.Mines == c.Mines &&
                                          x.Notes == c.Notes &&
                                          x.Rolls == c.Rolls &&
                                          x.Stream == c.Stream &&
                                          x.TapsAndHolds == c.TapsAndHolds &&
                                          x.Voltage == c.Voltage).FirstOrDefault();
                if (s != null) c.Id = s.Id;
            });
            return result;
        }
    }
}
