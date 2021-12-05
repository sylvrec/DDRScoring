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

        [TestMethod]
        public void TestMergeKeySongIssue1()
        {
            List<Song> songs1 = new List<Song>()
            {
                new Song() { Name = "First", Steps = null },
                new Song() { Name = "Second", Steps = null },
            };
            List<Song> songs2 = new List<Song>()
            {
                new Song() { Id = 1, Name = "First", Steps = null },
                new Song() { Id = 2, Name = "Second", Steps = null },
            };
            var newSongs1 = songs1.MergeKey(songs2).ToList();
            Assert.AreEqual(1, newSongs1[0].Id);
            Assert.AreEqual(2, newSongs1[1].Id);
        }

        [TestMethod]
        public void TestMergeKeySongIssue2()
        {
            List<Song> songs1 = new List<Song>()
            {
                new Song() { Name = "First", Steps = null },
                new Song() { Name = "Second", Steps = null },
                new Song() { Name = "Third", Steps = null },
            };
            List<Song> songs2 = new List<Song>()
            {
                new Song() { Id = 1, Name = "First", Steps = null },
                new Song() { Id = 2, Name = "Second", Steps = null },
            };
            var newSongs1 = songs1.MergeKey(songs2).ToList();
            Assert.AreEqual(3, newSongs1.Count());
        }

        [TestMethod]
        public void TestMergeKeySongIssue3()
        {
            List<Song> songs1 = new List<Song>()
            {
                new Song() { Name = "First", Steps = null },
                new Song() { Name = "Second", Steps = null },
            };
            List<Song> songs2 = new List<Song>()
            {
                new Song() { Id = 1, Name = "First", Steps = null },
                new Song() { Id = 2, Name = "Second", Steps = null },
                new Song() { Id = 3 , Name = "Third", Steps = null },
            };
            var newSongs1 = songs1.MergeKey(songs2).ToList();
            Assert.AreEqual(2, newSongs1.Count());
        }

        [TestMethod]
        public void TestMergeKeySongIssue4()
        {
            List<Song> songs1 = new List<Song>()
            {
                new Song() { Name = "First", Steps = null },
                new Song() { Name = null, Steps = null },
            };
            List<Song> songs2 = new List<Song>()
            {
                new Song() { Id = 1, Name = "First", Steps = null },
                new Song() { Id = 2, Name = "Second", Steps = null },
                new Song() { Id = 3 , Name = null, Steps = null },
            };
            var newSongs1 = songs1.MergeKey(songs2).ToList();
            Assert.AreEqual(2, newSongs1.Count());
        }
    }
}
