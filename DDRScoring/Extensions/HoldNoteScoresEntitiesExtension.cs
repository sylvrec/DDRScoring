using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Extensions
{
    public static class HoldNoteScoresEntitiesExtension
    {
        public static IEnumerable<HoldNoteScores> Except(this IList<HoldNoteScores> first, IList<HoldNoteScores> second)
        {
            foreach (var holdNoteScore in first)
            {
                if (!second.Where(x => x.Held == holdNoteScore.Held &&
                                       x.MissedHold == holdNoteScore.MissedHold &&
                                       x.LetGo == holdNoteScore.LetGo).Any())
                {
                    yield return holdNoteScore;
                }
            }
        }
    }
}
