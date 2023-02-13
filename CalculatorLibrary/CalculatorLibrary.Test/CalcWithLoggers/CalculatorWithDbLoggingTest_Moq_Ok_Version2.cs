using CalculatorLibrary.Loggers;
using CalculatorLibrary.Test.Mocks.Moq;
using NUnit.Framework;

namespace CalculatorLibrary.Test.CalcWithLoggers
{
    public class CalculatorWithDbLoggingTest_Moq_Ok_Version2 // отличается от первого варианта тем, что
    {
        private ICalculator _systemUnderTests;
        private ICalculator _calculator;
        private ILogger _logger;

        [SetUp]
        public void Setup()
        {
            _calculator = CalculatorMoqFactory.Order(); // метод ордер не принимает тут аргумента returnValue
            _logger = LoggerMoqFactory.Order();
            _systemUnderTests = new CalculatorWithDbLogging_Ok(_logger, _calculator);
        }

        [TestCase(2, 3, 5)]
        public void GIVEN_Calculator_WHEN_Sum_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Sum(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 3, 1)]
        public void GIVEN_Calculator_WHEN_Diff_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Diff(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 6)]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Multiply(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 3, 2)]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Divide(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 0)]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown(
            decimal a,
            decimal b
            )
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(a, b); });
        }
    }
}
