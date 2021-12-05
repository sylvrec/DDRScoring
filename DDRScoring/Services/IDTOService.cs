using DDRScoring.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Services
{
    public interface IDTOService
    {
        List<Song> StatsToGetSongs();
        List<Steps> StatsToGetSteps();
        List<HighScoreList> StatsToGetHighScoreList();
        List<HighScore> StatsToGetHighScore();
        List<TapNoteScores> StatsToGetTapNoteScores();
        List<HoldNoteScores> StatsToGetHoldNoteScores();
        List<RadarValues> StatsToGetRadarValues();
    }
}
