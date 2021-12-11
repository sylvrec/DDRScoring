using DDRScoring.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class PlayerRepository : DDRScoringRepository<Player>, IPlayerRepository
    {
        private readonly UserManager<StoreUser> _userManager;

        public PlayerRepository(DDRScoringContext context, UserManager<StoreUser> userManager)
            : base(context)
        {
            _userManager = userManager;
        }

        public async Task<Player> GetPlayerAuthentifiedAsync(ClaimsPrincipal user)
        {
            var storeUser = await _userManager.GetUserAsync(user);
            if (storeUser == null) return null;
            return _context.Players.Where(x => x.Account.Id == storeUser.Id).FirstOrDefault();
        }

        public Player GetPlayerByEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return null;
            return _context.Players.Where(x => x.Account.Email == email).First();
        }

        public IList<Player> AllPlayerWithSong(Song song)
        {
            return _context.Song.Where(x => x.Name == song.Name)
                                        .Include(x => x.Player)
                                        .Select(x => x.Player)
                                        .ToList();
        }
    }
}
