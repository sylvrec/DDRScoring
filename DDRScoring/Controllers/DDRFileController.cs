using AutoMapper;
using DDRScoring.Data;
using DDRScoring.Data.DTO;
using DDRScoring.Data.Entities;
using DDRScoring.Data.Repository;
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
        private readonly DDRScoringContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<StoreUser> _userManger;

        public DDRFileController(ILogger<DDRFileController> logger,
                                 DDRScoringContext context,
                                 IMapper mapper,
                                 UserManager<StoreUser> userManger)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
            _userManger = userManger;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]Stats stats)
        {
            _logger.LogDebug(stats.ToString());
            var player = new Player();             
            player.Account = await _userManger.GetUserAsync(User);
            if (player.Account == null) return BadRequest();
            player.Songs = _mapper.Map<IList<Data.DTO.Song>, IList<Data.Entities.Song>>(stats.SongScores.Song);
            player.CaloriesBurneds = _mapper.Map<IList<Data.DTO.CaloriesBurned>, IList<Data.Entities.CaloriesBurned>>(stats.CalorieData.CaloriesBurned);
            _context.Players.Add(player);
            try
            {
                await _context.SaveChangesAsync();
            } 
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex.InnerException.Message);
            }
            return Ok();
        }
    }
}
