using System;
using System.Threading.Tasks;
using Moq;
using Xunit;
using FluentAssertions;
using application.BankAccountService;
using domain.Application;

namespace tests.Application
{
    public class BankAccountServiceTests
    {
        private readonly Mock<IConsoleLoggerService> _logger;
        private readonly BankAccountService _bankAccountService;

        public BankAccountServiceTests()
        {
            _logger = new Mock<IConsoleLoggerService>();
            _bankAccountService = new BankAccountService(_logger.Object);
        }

        [Fact]
        public async Task WithdrawMoneyAsync_ShouldLogBankBalance_WhenFundsAreSufficient()
        {
            // Arrange
            decimal withdrawAmount = 50m;
            string expectedLogMessage = "It's your bank balance now: 50";

            // Act
            await _bankAccountService.WithdrawMoneyAsync(withdrawAmount);

            // Assert
            _logger.Verify(l => l.Log(It.Is<string>(s => s.Contains(expectedLogMessage))), Times.Once);
        }

        [Fact]
        public async Task WithdrawMoneyAsync_ShouldLogInsufficientFunds_WhenFundsAreInsufficient()
        {
            // Arrange
            decimal withdrawAmount = 150m;
            string expectedLogMessage = "Insufficient funds";

            // Act
            await _bankAccountService.WithdrawMoneyAsync(withdrawAmount);

            // Assert
            _logger.Verify(l => l.Log(It.Is<string>(s => s.Contains(expectedLogMessage))), Times.Once);
        }
    }
}
