using AutoFixture;
using NUnit.Framework;

namespace CalculatorLibrary.Test.Calc
{
    public class CalculatorTests_AutoFxiture
    {
        private static Fixture _fixture = new Fixture();
        private ICalculator _systemUnderTests;

        private decimal _a;
        private decimal _b;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new Calculator();
            //_systemUnderTests = new FakeCalculator();

            _a = _fixture.Create<decimal>(); // создаёт любое значение в диапозоне этой переменной
            _b = _fixture.Create<decimal>();
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Sum_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Sum(_a, _b);
            NUnit.Framework.Assert.AreEqual(_a + _b, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Diff_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Diff(_a, _b);
            NUnit.Framework.Assert.AreEqual(_a - _b, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Multiply(_a, _b);
            NUnit.Framework.Assert.AreEqual(_a * _b, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Divide(_a, _b);
            NUnit.Framework.Assert.AreEqual(_a / _b, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown()
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(_a, 0); });
        }
    }
}