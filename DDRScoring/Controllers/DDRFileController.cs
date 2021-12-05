using AutoMapper;
using DDRScoring.Data;
using DDRScoring.Data.DTO;
using DDRScoring.Data.Entities;
using DDRScoring.Data.Repository;
using DDRScoring.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DDRScoring.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/ddrfile")]
    public class DDRFileController : ControllerBase
    {
        private readonly ILogger<DDRFileController> _logger;
        private readonly ISaveScoringService _serviceSaveScoring;
        private readonly UserManager<StoreUser> _userManger;

        public DDRFileController(ILogger<DDRFileController> logger,
                                 ISaveScoringService serviceSaveScoring,
                                 IMapper mapper,
                                 UserManager<StoreUser> userManger)
        {
            _logger = logger;
            _serviceSaveScoring = serviceSaveScoring;
            _userManger = userManger;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]Stats stats)
        {
            _logger.LogDebug(stats.ToString());
            var result = await _serviceSaveScoring.SaveAndMergeAsync(User, stats);
            return Ok();
        }
    }
}
