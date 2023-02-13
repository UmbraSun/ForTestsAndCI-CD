using NUnit.Framework;

namespace CalculatorLibrary.Test.CalcWithLoggers
{
    public class CalculatorWithDbLoggingTest_Bad
    {
        private ICalculator _systemUnderTests;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new CalculatorWithDbLogging_Bad();
        }

        [Test]
        [NUnit.Framework.Ignore("This test fails always.")]    // аттрибут который позволяет игнорировать тесты
                                                               // как видно из сообщения передаваемого в аттрибут
                                                               // эта реализация никогда не отработает
                                                               // так как сам пример плохой
        public void GIVEN_Calculator_WHEN_Sum_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Sum(2, 3);
            NUnit.Framework.Assert.AreEqual(5, actual);
        }

        [Test]
        [NUnit.Framework.Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Diff_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Diff(2, 3);
            NUnit.Framework.Assert.AreEqual(-1, actual);
        }

        [Test]
        [NUnit.Framework.Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Multiply(2, 3);
            NUnit.Framework.Assert.AreEqual(6, actual);
        }

        [Test]
        [NUnit.Framework.Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Divide(4, 2);
            NUnit.Framework.Assert.AreEqual(2, actual);
        }

        [Test]
        [NUnit.Framework.Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown()
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(4, 0); });
        }
    }
}