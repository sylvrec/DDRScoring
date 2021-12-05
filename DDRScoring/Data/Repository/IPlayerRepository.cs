using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository
{
    public interface IPlayerRepository : IDDRScoringRepository<Player>
    {
        Task<Player> GetPlayerAuthentifiedAsync(ClaimsPrincipal user);
        Player GetPlayerByEmail(string email);
    }
}
