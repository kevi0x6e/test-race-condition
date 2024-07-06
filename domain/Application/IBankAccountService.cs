using System;

namespace domain.Application
{
    public interface IBankAccountService
    {
        Task WithdrawMoneyAsync(decimal value);
    }
}
