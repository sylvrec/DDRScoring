using DDRScoring.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data
{
    public class DDRScoringRepository : IDDRScoringRepository
    {
        private readonly DDRScoringContext _context;
        private readonly UserManager<StoreUser> _userManager;

        public DDRScoringRepository(DDRScoringContext context, UserManager<StoreUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<StoreUser> GetStoreUserByClaimsAsync(IEnumerable<Claim> claims)
        {
            foreach (var claim in claims)
            {
                if (claim.Type == JwtRegisteredClaimNames.Sub)
                {
                    var user = await _userManager.FindByEmailAsync(claim.Value);
                    if (user == null || string.IsNullOrEmpty(user.Email))
                        return null;
                    return await _userManager.FindByEmailAsync(user.Email);
                }
            }
            return null;
        }
    }
}
