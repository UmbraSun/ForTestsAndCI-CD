using NUnit.Framework;

namespace CalculatorLibrary.Test.Calc
{
    public class CalculatorTests
    {
        private ICalculator _systemUnderTests;

        [SetUp] // Стартует перед каждым тестом
        public void Setup()
        {
            _systemUnderTests = new Calculator(); // создаваемый объект для тестирования
            // _systemUnderTests = new FakeCalculator();
        }

        [Test] // Аттрибут, который показывает, что метод является тестом
        public void GIVEN_Calculator_WHEN_Sum_method_is_invoked_THEN_correct_value_is_returned()
        {
            var result = _systemUnderTests.Sum(2, 3);
            NUnit.Framework.Assert.AreEqual(5, result);
        }

        [Test]
        public void GIVEN_Calculator_When_Diff_method_is_invoked_THEN_correct_value_is_returned()
        {
            var result = _systemUnderTests.Diff(3, 2);
            NUnit.Framework.Assert.AreEqual(1, result);
        }

        [Test]
        public void GIVEN_Calculator_When_Multiply_method_is_invoked_THEN_correct_value_is_returned()
        {
            var result = _systemUnderTests.Multiply(3, 2);
            NUnit.Framework.Assert.AreEqual(6, result);
        }

        [Test]
        public void GIVEN_Calculator_When_Divide_method_is_invoked_THEN_correct_value_is_returned()
        {
            var result = _systemUnderTests.Divide(4, 2);
            NUnit.Framework.Assert.AreEqual(2, result);
        }

        [Test]
        public void GIVEN_Calculator_When_Divide_method_with_zero_divider_is_invoked_THEN_correct_value_is_returned()
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(4, 0); });
        }
    }
}
