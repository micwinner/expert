using AutoMapper;
using instrument.expert.dto;
using instrument.expert.model;

namespace instrument.expert.mapper.Profiles
{
    public class ExpertProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<EXP_Expert, EXP_ExpertDto>();
            //.ForMember(dest => dest.VIPZone_City, opt => opt.MapFrom(s => s.VIPZone_City))
            //.ForMember(dest => dest.VIPZone_Country, opt => opt.MapFrom(s => s.VIPZone_Country))
            //.ForMember(dest => dest.VIPZone_Province, opt => opt.MapFrom(s => s.VIPZone_Province));
            CreateMap<EXP_ExpertDto, EXP_Expert>();
            //.ForMember(dest => dest.VIPZone_City, opt => opt.MapFrom(s => s.VIPZone_City))
            //.ForMember(dest => dest.VIPZone_Country, opt => opt.MapFrom(s => s.VIPZone_Country))
            //.ForMember(dest => dest.VIPZone_Province, opt => opt.MapFrom(s => s.VIPZone_Province));
        }
    }
}