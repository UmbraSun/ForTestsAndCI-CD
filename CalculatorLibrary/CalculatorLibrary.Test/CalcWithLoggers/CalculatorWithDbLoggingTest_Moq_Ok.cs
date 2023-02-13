using AutoFixture;
using CalculatorLibrary.Loggers;
using CalculatorLibrary.Test.Mocks.Moq;
using NUnit.Framework;
using System;

namespace CalculatorLibrary.Test.CalcWithLoggers
{
    public class CalculatorWithDbLoggingTest_Moq_Ok
    {
        private static Fixture _fixture = new Fixture();

        private ICalculator _systemUnderTests;
        private ICalculator _calculator;
        private ILogger _logger;

        private decimal _returnValue;

        [SetUp]
        public void Setup()
        {
            _returnValue = _fixture.Create<decimal>();
            _calculator = CalculatorMoqFactory.Order(_returnValue);
            _logger = LoggerMoqFactory.Order();
            _systemUnderTests = new CalculatorWithDbLogging_Ok(_logger, _calculator);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Sum_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Sum(2, 3);
            NUnit.Framework.Assert.AreEqual(_returnValue, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Diff_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Diff(2, 3);
            NUnit.Framework.Assert.AreEqual(_returnValue, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Multiply(2, 3);
            NUnit.Framework.Assert.AreEqual(_returnValue, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Divide(4, 2);
            NUnit.Framework.Assert.AreEqual(_returnValue, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown()
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(4, 0); });
        }
    }
}
