using DDRScoring.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DDRScoring.Controllers
{
    [ApiController]
    [Route("/api/ddrfile")]
    public class DDRFileController : ControllerBase
    {
        private readonly ILogger<DDRFileController> _logger;

        public DDRFileController(ILogger<DDRFileController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Stats stats)
        {
            _logger.LogTrace(stats.ToString());
            return Ok();
        }
    }
}
