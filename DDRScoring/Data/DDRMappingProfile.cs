using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data
{
    public class DDRMappingProfile : Profile
    {
        public DDRMappingProfile()
        {
            // Entities < = > DTO
            CreateMap<Entities.Steps, DTO.Steps>()
                .ReverseMap();
            CreateMap<Entities.Song, DTO.Song>()
                .ReverseMap();
            CreateMap<Entities.HighScore, DTO.HighScore>()
                .ReverseMap();
            CreateMap<Entities.HighScoreList, DTO.HighScoreList>()
                .ReverseMap();
            CreateMap<Entities.HoldNoteScores, DTO.HoldNoteScores>()
                .ReverseMap();
            CreateMap<Entities.RadarValues, DTO.RadarValues>()
                .ReverseMap();
            CreateMap<Entities.TapNoteScores, DTO.TapNoteScores>()
                .ReverseMap();
            CreateMap<Entities.CaloriesBurned, DTO.CaloriesBurned>()
                .ReverseMap();
        }
    }
}
