using AutoFixture;
using CalculatorLibrary.DateTimeExample;
using CalculatorLibrary.DateTimeExample.Good;
using CalculatorLibrary.Test.Mocks.Moq.DateTimeMocks;
using NUnit.Framework;

namespace CalculatorLibrary.Test.DateTimeExampleTests.Good
{
    public class UserRegistartionTests
    {
        private static Fixture _fixture = new Fixture();

        private IRegistration _systemUnderTestsAfterThreshold;
        private IRegistration _systemUnderTestsBeforeThreshold;
        private IDateTimeProvider _dateTimeProviderAfterThreshold;
        private IDateTimeProvider _dateTimeProviderBeforeThreshold;
        private string _userName;

        [SetUp]
        public void Setup()
        {
            _dateTimeProviderAfterThreshold = DateTimeMockFactory.OrderWithDateAfterThreshold(); // обычные моки, которые должны вернуть значение после порога 
            _dateTimeProviderBeforeThreshold = DateTimeMockFactory.OrderWithDateBeforeThreshold(); // и до

            _systemUnderTestsAfterThreshold = new UserRegistration(_dateTimeProviderAfterThreshold);  // до того как наступило пороговое значение
            _systemUnderTestsBeforeThreshold = new UserRegistration(_dateTimeProviderBeforeThreshold); // после

            _userName = _fixture.Create<string>();
        }

        [Test]
        public void GIVEN_UserRegistration_WHEN_Register_method_is_invoked_after_threshold_THEN_false_is_returned()
        {
            var actual = _systemUnderTestsAfterThreshold.Register(_userName);
            NUnit.Framework.Assert.IsFalse(actual); // => тут предпологается что придёт False
        }

        [Test]
        public void GIVEN_UserRegistration_WHEN_Register_method_is_invoked_before_threshold_THEN_true_is_returned()
        {
            var actual = _systemUnderTestsBeforeThreshold.Register(_userName);
            NUnit.Framework.Assert.IsTrue(actual); // а тут ожидается True так как значение правильное
        }
    }
}
