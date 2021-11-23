using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDDRScoring.Data
{
    [TestClass]
    public class TestAutoMapper
    {
        [TestMethod]
        public void AutoMapperConfigValid()
        {
            var map = new MapperConfiguration(cfg => {
                cfg.AddProfile(new DDRScoring.Data.DDRMappingProfile());
            });
            map.AssertConfigurationIsValid();
        }
    }
}
