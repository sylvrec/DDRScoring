using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data
{
    public interface IDDRScoringRepository
    {
        Task<StoreUser> GetStoreUserByClaimsAsync(IEnumerable<Claim> claims);
    }
}
