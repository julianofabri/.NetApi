using BankApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers
{
    public class CashMachineController : ControllerBase
    {
        private readonly CashMachineService _service;
        public CashMachineController(CashMachineService service)
        {
            _service = service;
        }

        [HttpPut("Deposit")]
        public IActionResult Deposit([FromQuery] double value, [FromQuery] string agency)
        {
            _service.Deposit(value, agency);
            return Ok();
        }
    }
}
