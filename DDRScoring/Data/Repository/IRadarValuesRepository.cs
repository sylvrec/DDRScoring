﻿using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository
{
    public interface IRadarValuesRepository : IDDRScoringRepository<RadarValues>
    {
        IList<RadarValues> RadarValuesByHighScore(IList<HighScore> highScores);
    }
}
