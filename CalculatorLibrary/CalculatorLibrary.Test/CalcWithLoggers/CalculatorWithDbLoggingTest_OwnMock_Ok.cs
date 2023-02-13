using CalculatorLibrary.Loggers;
using CalculatorLibrary.Test.Mocks.Own;
using NUnit.Framework;

namespace CalculatorLibrary.Test.CalcWithLoggers
{
    public class CalculatorWithDbLoggingTest_OwnMock_Ok
    {
        private ICalculator _systemUnderTests;
        private ICalculator _calculator;
        private ILogger _logger;

        [SetUp]
        public void Setup() // возможно это будет работать, но это не совсем хорошо и то что нам нужно
        {
            _calculator = new CalculatorOwnMock(); 
            _logger = new LoggerOwnMock(); // моковые объекты которые не мешают работе тестов без какой-либо реализации в себе
            _systemUnderTests = new CalculatorWithDbLogging_Ok(_logger, _calculator);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Sum_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Sum(2, 3);
            NUnit.Framework.Assert.AreEqual(0, actual); // всегда должен ровняться нулю потому что мы подсовываем моковый объект
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Diff_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Diff(2, 3);
            NUnit.Framework.Assert.AreEqual(0, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Multiply(2, 3);
            NUnit.Framework.Assert.AreEqual(0, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Divide(4, 2);
            NUnit.Framework.Assert.AreEqual(0, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown()
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(4, 0); });
        }
    }
}
