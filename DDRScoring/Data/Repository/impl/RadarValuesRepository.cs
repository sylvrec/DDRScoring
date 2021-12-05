using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class RadarValuesRepository : DDRScoringRepository<RadarValues>, IRadarValuesRepository
    {
        public RadarValuesRepository(DDRScoringContext context)
            : base(context)
        {

        }

        public IList<RadarValues> RadarValuesByHighScore(IList<HighScore> highScores)
        {
            List<RadarValues> list = new List<RadarValues>();

            foreach (var highScore in highScores)
            {
                var radarValues = _context.RadarValues.Where(x => x.Id == highScore.RadarValuesId).FirstOrDefault();
                if (radarValues != null)
                    list.Add(radarValues);
            }
            return list;
        }
    }
}
