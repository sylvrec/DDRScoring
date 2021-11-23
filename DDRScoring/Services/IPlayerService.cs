using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Services
{
    public interface IPlayerService
    {
        Task<StoreUser> GetAccountAuthentifiedAsync(ClaimsPrincipal claims);
        Task<Player> GetPlayerAuthentified(ClaimsPrincipal claims);
        
    }
}
