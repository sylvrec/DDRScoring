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

            // STEP
            CreateMap<Entities.Steps, DTO.Steps>();
            CreateMap<DTO.Steps, Entities.Steps>()
                .ForMember(e => e.Id, opt => opt.Ignore())
                .ForMember(e => e.SongId, opt => opt.Ignore())
                .ForMember(e => e.HighScoreListId, opt => opt.Ignore());
            
            // SONG
            CreateMap<Entities.Song, DTO.Song>()
                .ForMember(d => d.Dir, opt => opt.MapFrom(src => src.Name));
            CreateMap<DTO.Song, Entities.Song>()
                .ForMember(e => e.Id, opt => opt.Ignore())
                .ForMember(e => e.Name, opt => opt.MapFrom(src => src.Dir))
                .ForMember(e => e.PlayerId, opt => opt.Ignore());

            // HighScoreList
            CreateMap<Entities.HighScoreList, DTO.HighScoreList>();
            CreateMap<DTO.HighScoreList, Entities.HighScoreList>()
                .ForMember(e => e.Id, opt => opt.Ignore());

            // HighScore
            CreateMap<Entities.HighScore, DTO.HighScore>()
                .ForMember(d => d.DateTime, opt => opt.MapFrom(src => src.DateTime.ToString()));
            CreateMap<DTO.HighScore, Entities.HighScore>()
                .ForMember(e => e.Id, opt => opt.Ignore())
                .ForMember(e => e.DateTime, opt => opt.MapFrom(src => DateTime.Parse(src.DateTime)))
                .ForMember(e => e.HighScoreListId, opt => opt.Ignore())
                .ForMember(e => e.TapNoteScoresId, opt => opt.Ignore())
                .ForMember(e => e.RadarValuesId, opt => opt.Ignore());
            
            //HoldNoteScore
            CreateMap<Entities.HoldNoteScores, DTO.HoldNoteScores>();
            CreateMap<DTO.HoldNoteScores, Entities.HoldNoteScores>()
                .ForMember(e => e.Id, opt => opt.Ignore());

            // RadarValues
            CreateMap<Entities.RadarValues, DTO.RadarValues>();
            CreateMap<DTO.RadarValues, Entities.RadarValues>()
                .ForMember(e => e.Id, opt => opt.Ignore());

            // TapNoteScores
            CreateMap<Entities.TapNoteScores, DTO.TapNoteScores>();
            CreateMap<DTO.TapNoteScores, Entities.TapNoteScores>()
                .ForMember(e => e.Id, opt => opt.Ignore());
            
            // CaloriesBurned
            CreateMap<Entities.CaloriesBurned, DTO.CaloriesBurned>();
            CreateMap<DTO.CaloriesBurned, Entities.CaloriesBurned>()
                .ForMember(e => e.Id, opt => opt.Ignore())
                .ForMember(e => e.PlayerId, opt => opt.Ignore());
        }
    }
}
