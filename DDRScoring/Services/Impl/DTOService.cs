using AutoMapper;
using DDRScoring.Data.DTO;
using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Services.Impl
{
    public class DTOService : IDTOService
    {
        private readonly IMapper _mapper;

        public DTOService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Data.Entities.Player DTOStatsToEntitiesPlayer(Data.DTO.Stats stats, StoreUser user)
        {
            Data.Entities.Player player = new Data.Entities.Player();
            player.Account = user;
            player.Songs = _mapper.Map<List<Data.DTO.Song>, List<Data.Entities.Song>>(stats.SongScores.Song);
            player.CaloriesBurneds = _mapper.Map<List<Data.DTO.CaloriesBurned>, List<Data.Entities.CaloriesBurned>>(stats.CalorieData.CaloriesBurned);
            return player;
        }

    }
}
