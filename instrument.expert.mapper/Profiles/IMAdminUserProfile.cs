using AutoMapper;
using instrument.expert.dto;
using instrument.expert.model;

namespace instrument.expert.mapper.Profiles
{
    public class IMAdminUserProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<IM_Admin_User, IM_AdminUserDto>();
            CreateMap<IM_AdminUserDto, IM_Admin_User>();
        }
    }
}