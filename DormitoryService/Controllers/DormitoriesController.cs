using AutoMapper;
using DormitoryService.Data;
using DormitoryService.DTO;
using DormitoryService.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DormitoryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DormitoriesController : ControllerBase
    {
        private IDormitoryRepo _dormitoryRepo;
        private IMapper _mapper;

        public DormitoriesController(IDormitoryRepo dormitoryRepo, IMapper mapper)
        {
            _dormitoryRepo = dormitoryRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<DormitoryReadDTO>> GetDormitories()
        {
            var dormitories = _dormitoryRepo.GetDormitories();

            return Ok(_mapper.Map<ICollection<DormitoryReadDTO>>(dormitories));
        }

        [HttpGet("{id}", Name = "GetDormitoryById")]
        public ActionResult<DormitoryReadDTO> GetDormitoryById(int id)
        {
            var dormitory = _dormitoryRepo.GetDormitoryById(id);

            if (dormitory != null)
            {
                return Ok(_mapper.Map<DormitoryReadDTO>(dormitory));
            }

            return NotFound();
        }

        // [HttpGet("{name}")]
        // public ActionResult<DormitoryReadDTO> GetDormitoryById(string name)
        // {
        //     var dormitory = _dormitoryRepo.GetDormitoryByName(name);

        //     if (dormitory != null)
        //     {
        //         return Ok(_mapper.Map<DormitoryReadDTO>(dormitory));
        //     }

        //     return NotFound();
        // }

        [HttpPost]
        public ActionResult<DormitoryReadDTO> AddDormitory(DormitoryMakeDTO dormitoryDTO)
        {
            Dormitory dormitory = _mapper.Map<Dormitory>(dormitoryDTO);

            _dormitoryRepo.AddDormitory(dormitory);

            _dormitoryRepo.SaveChanges();

            DormitoryReadDTO dormitoryReadDTO = _mapper.Map<DormitoryReadDTO>(dormitory);

            return CreatedAtRoute(nameof(GetDormitoryById), new {dormitoryReadDTO.Id}, dormitoryReadDTO);
        }
    }
}