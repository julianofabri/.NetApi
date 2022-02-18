using AutoMapper;
using BankApi.Dtos;
using BankApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatmentController : Controller
    {
        private readonly IMapper _mapper;
        private readonly StatmentService _service;

        public StatmentController(StatmentService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result.Select(model => _mapper.Map<StatmentDto>(model)));
        }
        
        [HttpGet("GetByAccountId/{accountId}")]
        public IActionResult GetByAccountId(long accountId)
        {
            var result = _service.GetByAccountId(accountId);
            return Ok(result.Select(model => _mapper.Map<StatmentDto>(model)));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var result = _service.GetById(id);
            return Ok(_mapper.Map<StatmentDto>(result));
        }

        [HttpPost]
        public IActionResult AddStatment(StatmentDto StatmentDto)
        {
            _service.AddStatment(StatmentDto);
            return new ObjectResult(null) { StatusCode = StatusCodes.Status201Created };
        }

        [HttpPatch]
        public IActionResult UpdateStatment(StatmentDto statmentDto, long id)
        {
            _service.UpdateStatment(statmentDto, id);
            return new ObjectResult(null) { StatusCode = StatusCodes.Status202Accepted };
        }

    }
}
