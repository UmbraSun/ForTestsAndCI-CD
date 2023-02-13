using AutoFixture;
using CalculatorLibrary.DateTimeExample;
using CalculatorLibrary.DateTimeExample.Bad;
using NUnit.Framework;

namespace CalculatorLibrary.Test.DateTimeExampleTests.Bad
{
    public class UserRegistartionTests_B
    {
        private static Fixture _fixture = new Fixture();

        private IRegistration _systemUnderTests;
        private string _userName;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new UserRegistration_B();
            _userName = _fixture.Create<string>();
        }

        [Test]
        [NUnit.Framework.Ignore("This test fails always.")]
        public void GIVEN_UserRegistration_WHEN_Register_method_is_invoked_before_threshold_THEN_true_is_returned()
        {
            var actual = _systemUnderTests.Register(_userName);
            NUnit.Framework.Assert.IsTrue(actual);
        }
    }
}