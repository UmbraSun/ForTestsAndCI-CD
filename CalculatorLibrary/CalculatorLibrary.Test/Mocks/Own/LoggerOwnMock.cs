using CalculatorLibrary.Loggers;

namespace CalculatorLibrary.Test.Mocks.Own
{
    class LoggerOwnMock : ILogger // класс который по сути ничего не делает, не влияет на работу мокового класса
    {
        public void Log(string logMessage)
        {
            return;
        }
    }
}
