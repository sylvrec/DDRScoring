using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class SongRepository : DDRScoringRepository<Song>, ISongRepository
    {
        public SongRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public List<long> SongsToIds(List<Song> songs)
        {
            List<long> ids = new();
            foreach (var s in songs)
            {
                ids.Add(s.Id);
            }
            return ids;
        }

        public IList<Song> SongByPlayer(Player player)
        {
            return _context.Song.Where(x => x.PlayerId == player.Id).ToList();
        }
    }
}
