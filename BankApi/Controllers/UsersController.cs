using AutoMapper;
using BankApi.Dtos;
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
        public UsersController(UserService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result.Select(model => _mapper.Map<UserDto>(model)));
        }
    }
}
