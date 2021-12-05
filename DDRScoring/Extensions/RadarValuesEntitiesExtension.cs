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
    }
}
