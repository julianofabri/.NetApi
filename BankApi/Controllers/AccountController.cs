using AutoMapper;
using BankApi.Dtos;
using BankApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AccountService _service;

        public AccountController(AccountService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result.Select(model => _mapper.Map<AccountDto>(model)));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var result = _service.GetById(id);
            return Ok(_mapper.Map<AccountDto>(result));
        }

        [HttpPost]
        public IActionResult AddAccount(AccountDto AccountDto)
        {
            _service.AddAccount(AccountDto);
            return new ObjectResult(null) { StatusCode = StatusCodes.Status201Created };
        }

        [HttpPatch]
        public IActionResult UpdateAccount(AccountDto accountDto, long id)
        {
            _service.UpdateAccount(accountDto, id);
            return new ObjectResult(null) { StatusCode = StatusCodes.Status202Accepted };
        }

        [HttpPost("deposit")]
        public IActionResult AccountDeposit(float depositValue, long id)
        {
            _service.AccountDeposit(depositValue, id);
            return new ObjectResult(null) { StatusCode = StatusCodes.Status202Accepted };
        }

        [HttpPost("withdraw")]
        public IActionResult AccountWithdrawValue(float depositValue, long id)
        {
            _service.AccountWithdraw(depositValue, id);
            return new ObjectResult(null) { StatusCode = StatusCodes.Status202Accepted };
        }
    }
}
