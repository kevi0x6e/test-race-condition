using System;
using domain.Application;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountService _bankAccountService;

        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        [HttpPost()]
        public async Task<IActionResult> WithdrawMoneyAsync(decimal value)
        {
            await _bankAccountService.WithdrawMoneyAsync(value);

            return Ok();
        }
    }
}
