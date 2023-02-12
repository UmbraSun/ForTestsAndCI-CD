using NUnit.Framework;

namespace CalculatorLibrary.Test.TestScenarios
{
    public class CalculatorTests_TestScenarios_B
    {
        private ICalculator _systemUnderTests;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new Calculator();
            //_systemUnderTests = new FakeCalculator();
        }

        [TestCaseSource(nameof(SumCases))] // аттрибут для принимаемой сущности, которую мы будем прогонять по тестам
        public void GIVEN_Calculator_WHEN_Sum_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected)
        {
            var actual = _systemUnderTests.Sum(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(DiffCases))]
        public void GIVEN_Calculator_WHEN_Diff_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Diff(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(MultipleCases))]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Multiply(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(DivideCases))]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Divide(a, b);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(DivideCasesWithZeroDivider))]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown(
            decimal a,
            decimal b
            )
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(a, b); });
        }

        static object[] SumCases =
        {
            new object[] { 2M, 3M, 5M },
            new object[] { 3M, 4M, 7M },
            new object[] { 4M, 5M, 9M }
        };

        static object[] DiffCases =
        {
            new object[] { 4M, 3M, 1M },
            new object[] { 6M, 4M, 2M },
            new object[] { 8M, 5M, 3M }
        };

        static object[] MultipleCases =
        {
            new object[] { 2M, 3M, 6M },
            new object[] { 3M, 4M, 12M },
            new object[] { 4M, 5M, 20M }
        };

        static object[] DivideCases =
        {
            new object[] { 6M, 3M, 2M },
            new object[] { 12M, 4M, 3M },
            new object[] { 20M, 5M, 4M }
        };

        static object[] DivideCasesWithZeroDivider =
        {
            new object[] { 6M, 0M },
            new object[] { 12M, 0M },
            new object[] { 20M, 0M }
        };
    }
}