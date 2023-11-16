using AutoMapper;
using RequestService.DTO;
using RequestService.Models;

namespace RequestService.Profiles
{
    public class RequestProfile : Profile
    {
        public RequestProfile()
        {
            CreateMap<UserRequest, UserRequestReadDTO>();
            CreateMap<UserRequestMakeDTO, UserRequest>();
        }
    }
}