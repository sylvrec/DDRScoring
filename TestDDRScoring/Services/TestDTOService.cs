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
        public void TestStatsToGetSongs()
        {
            var dtoService = new DTOService(_stats);
            var songs = dtoService.StatsToGetSongs();
            Assert.IsNotNull(songs);
            Assert.AreEqual(10, songs.Count);
        }

        [TestMethod]
        public void TestStatsToGetSteps()
        {
            var dtoService = new DTOService(_stats);
            var steps = dtoService.StatsToGetSteps();
            Assert.IsNotNull(steps);
            Assert.AreEqual(18, steps.Count);
        }
    }
}
