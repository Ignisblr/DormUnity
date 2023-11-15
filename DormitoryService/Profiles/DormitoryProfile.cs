using AutoMapper;
using DormitoryService.DTO;
using DormitoryService.Models;

namespace DormitoryService.Profiles
{
    public class DormitoryProfile : Profile
    {
        public DormitoryProfile()
        {
            CreateMap<Dormitory, DormitoryReadDTO>();
            CreateMap<DormitoryMakeDTO, Dormitory>();
        }
    }
}