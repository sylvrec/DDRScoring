using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Extensions
{
    public static class TapNoteScoresEntitiesExtension
    {
        public static IEnumerable<TapNoteScores> Except(this IList<TapNoteScores> first, IList<TapNoteScores> second)
        {
            foreach (var tapNoteScores in first)
            {
                if (!second.Where(x => x.W1 == tapNoteScores.W1 &&
                                       x.W2 == tapNoteScores.W2 &&
                                       x.W3 == tapNoteScores.W3 &&
                                       x.W4 == tapNoteScores.W4 &&
                                       x.W5 == tapNoteScores.W5 &&
                                       x.Miss == tapNoteScores.Miss &&
                                       x.HitMine == tapNoteScores.HitMine &&
                                       x.CheckpointHit == tapNoteScores.CheckpointHit &&
                                       x.CheckpointMiss == tapNoteScores.CheckpointMiss).Any())
                {
                    yield return tapNoteScores;
                }
            }
        }
    }
}
