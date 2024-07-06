using System;
using domain.Application;
using System.Diagnostics.CodeAnalysis;

namespace application.LoggerService
{
    [ExcludeFromCodeCoverage]
    public class ConsoleLoggerService : IConsoleLoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }
}
