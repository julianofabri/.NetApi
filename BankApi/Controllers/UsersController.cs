using AutoMapper;
using BankApi.Dtos;
using BankApi.Repository;
using BankApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserService _service;
        private readonly UserRepository _userRepository;
        public UsersController(UserService service, IMapper mapper, UserRepository userRepository)
        {
            _mapper = mapper;
            _service = service;
            _userRepository = userRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result.Select(model => _mapper.Map<UserDto>(model)));
        }
    }
}
