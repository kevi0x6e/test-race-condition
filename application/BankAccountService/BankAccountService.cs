using System;
using domain.Application;

namespace application.BankAccountService
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IConsoleLoggerService _logger;

        public BankAccountService(IConsoleLoggerService consoleLoggerService)
        {
            _logger = consoleLoggerService ?? throw new ArgumentNullException(nameof(consoleLoggerService));;
        }

        public Task WithdrawMoneyAsync(decimal value){
            decimal bankBalance = 100m;
            lock (this){
                if (bankBalance - value > 0) {
                    bankBalance -= value;
                    _logger.Log($"It's your bank balance now: {bankBalance}");
                }
                else {
                    _logger.Log($"Insufficient funds");
                }
            }

            return Task.CompletedTask;
        }
    }
}
