using DDRScoring.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Services.Impl
{
    public class PlayerService : IPlayerService
    {
        private readonly UserManager<StoreUser> _userManager;

        private Player _player;

        public PlayerService(UserManager<StoreUser> userManager)
        {
            _userManager = userManager;
            _player = new Player();
        }

        public async Task<StoreUser> GetAccountAuthentifiedAsync(ClaimsPrincipal claims)
        {
            return await _userManager.GetUserAsync(claims);
        }

        public async Task<Player> GetPlayerAuthentified(ClaimsPrincipal claims)
        {
            _player.Account = await GetAccountAuthentifiedAsync(claims);
            
            return _player;
        }
    }
}
