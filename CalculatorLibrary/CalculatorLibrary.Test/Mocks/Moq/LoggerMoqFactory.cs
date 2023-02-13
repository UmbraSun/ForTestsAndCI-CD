using CalculatorLibrary.Loggers;
using Moq;

namespace CalculatorLibrary.Test.Mocks.Moq
{
    static class LoggerMoqFactory
    {
        public static ILogger Order()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(m => m.Log(It.IsAny<string>())).Verifiable(); // проверяет что данный метод был вызван
            return mock.Object;
        }
    }
}
