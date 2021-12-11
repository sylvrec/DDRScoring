using AutoMapper;
using DDRScoring.Data;
using DDRScoring.Data.DTO;
using DDRScoring.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestDDRScoring.Services
{
    [TestClass]
    public class TestDTOService
    {
        public static Stats _stats;

        [ClassInitialize]
        public static void ClassInitialize(TestContext ctx)
        {
            using (StreamReader reader = new StreamReader(@"C:\Projects\olympp\DDRScoringOlympp\TestDDRScoring\Ressources\Stats.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Stats));
                _stats = (Stats)serializer.Deserialize(reader);
            }
        }

        [TestMethod]
        public void TestDTOtoEntitiesStats()
        {
            //var dtoService = new DTOService(mapper);
            //var player = dtoService.DTOStatsToEntitiesPlayer(_stats, null);
            //Assert.IsNotNull(player);
            //Assert.AreEqual(_stats.SongScores.Song.Count, player.Songs.Count);
            //Assert.AreEqual(_stats.SongScores.Song[0].Dir, player.Songs[0].Name);
            //Assert.AreEqual(_stats.CalorieData.CaloriesBurned.Count, player.CaloriesBurneds.Count);
            //Assert.AreEqual(_stats.CalorieData.CaloriesBurned[0].Date, player.CaloriesBurneds[0].Date);
        }
    }
}
