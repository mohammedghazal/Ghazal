using AutoMapper;
using jwt.API.Dtos;
using jwt.API.Models;

namespace jwt.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserForRegisterDto, User>();
            CreateMap<User, UserForLisDto>();
        }

    }
}