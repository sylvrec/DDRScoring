using DDRScoring.Data;
using DDRScoring.Data.Entities;
using DDRScoring.Data.Repository.impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDDRScoring.Repository
{
    [TestClass]
    public class TestHighScoreRepository
    {
        private readonly DDRScoringContext _context = new DDRScoringContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DDRScoringContext>());
        [TestMethod]
        public void TestHighScoreByPlayerAndSong()
        {
            HighScoreListRepository highScoreListRepository = new HighScoreListRepository(_context);
            var list = highScoreListRepository.HighScoreByPlayerAndSong(null, null);

            Assert.IsNotNull(list);
        }
    }
}
