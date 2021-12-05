using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Extensions
{
    public static class SongEntitiesExtension
    {
        public static IEnumerable<Song> Except(this IList<Song> first, IList<Song> second)
        {
            foreach (var song in first)
            {
                if (!second.Where(x => x.Name == song.Name).Any())
                {
                    yield return song;
                }
            }
        }

        public static IList<Song> MergeKey(this IList<Song> first, IList<Song> second)
        {
            List<Song> result = first.ToList();

            result.ForEach(c => {
                var s = second?.Where(x => x.Name == c?.Name)?.FirstOrDefault();
                if (s != null) c.Id = s.Id;
            });
            return result;
        }
    }
}
