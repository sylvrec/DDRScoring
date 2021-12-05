using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository
{
    public interface ISongRepository : IDDRScoringRepository<Song>
    {
        IList<Song> SongByPlayer(Player player);

        List<long> SongsToIds(List<Song> songs);
    }
}
