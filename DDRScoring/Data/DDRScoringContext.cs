using DDRScoring.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data
{
    public class DDRScoringContext : IdentityDbContext<StoreUser>
    {
        private readonly IConfiguration _config;

        public DbSet<Player> Players { get; set; }
        public DbSet<Steps> Steps { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<HighScoreList> HighScoreList { get; set; }
        public DbSet<HighScore> HighScore { get; set; }
        public DbSet<HoldNoteScores> HoldNoteScores { get; set; }
        public DbSet<TapNoteScores> TapNoteScores { get; set; }
        public DbSet<RadarValues> RadarValues { get; set; }
        public DbSet<CaloriesBurned> CaloriesBurned { get; set; }

        public DDRScoringContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DDRScoringContextDb"]);
        }
    }
}
