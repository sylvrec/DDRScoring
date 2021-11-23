using DDRScoring.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository.impl
{
    public class PlayerRepository : DDRScoringRepository<Player>, IPlayerRepository
    {        
        public PlayerRepository(DDRScoringContext context)
            : base(context)
        {
        }

        public Player GetPlayerByEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return null;
            return _context.Players.Where(x => x.Account.Email == email).First();
        }
    }
}
