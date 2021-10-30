using DDRScoring.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data
{
    public class DDRScoringContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
    }
}
