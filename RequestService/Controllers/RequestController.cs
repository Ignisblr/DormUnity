using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RequestService.Data;
using RequestService.DTO;
using RequestService.Models;

namespace RequestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        private IRequestRepo _requestRepo;
        private readonly IMapper _mapper;

        public RequestController(IRequestRepo requestRepo, IMapper mapper)
        {
            _requestRepo = requestRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<UserRequestReadDTO>> GetRequests()
        {
            var requests = _requestRepo.GetRequests();

            if (requests != null)
            {
                return Ok(_mapper.Map<UserRequestReadDTO>(requests));
            }

            return NotFound();
        }

        [HttpGet("{id}", Name = "GetRequestById")]
        public ActionResult<UserRequestReadDTO> GetRequestById(int id)
        {
            var request = _requestRepo.GetRequest(id);

            if (request != null)
            {
                return Ok(_mapper.Map<UserRequestReadDTO>(request));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<UserRequestReadDTO> AddDormitory(UserRequestReadDTO requestReadDTO)
        {
            UserRequest request = _mapper.Map<UserRequest>(requestReadDTO);

            _requestRepo.MakeRequest(request);

            _requestRepo.SaveChanges();

            UserRequestReadDTO userRequestReadDTO = _mapper.Map<UserRequestReadDTO>(request);

            return CreatedAtRoute(nameof(GetRequestById), new {userRequestReadDTO.Id}, userRequestReadDTO);
        }
    }
}