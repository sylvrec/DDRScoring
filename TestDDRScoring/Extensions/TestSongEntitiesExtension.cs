using DDRScoring.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDRScoring.Extensions;

namespace TestDDRScoring.Extensions
{
    [TestClass]
    public class TestSongEntitiesExtension
    {
        [TestMethod]
        public void TestExceptSong1ApporteUnChangement()
        {
            List<Song> songs1 = new List<Song>()
            {
                new Song() { Name = "First", Steps = null },
                new Song() { Name = "Second", Steps = null },
            };
            List<Song> songs2 = new List<Song>()
            {
                new Song() { Id = 1, Name = "First", Steps = null }
            };
            var newSong = songs1.Except(songs2).ToList();
            Assert.AreEqual(1, newSong.Count);
            Assert.AreEqual("Second", newSong[0].Name);
        }
    }
}
