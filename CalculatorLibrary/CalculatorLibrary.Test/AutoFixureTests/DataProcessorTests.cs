using AutoFixture;
using CalculatorLibrary.AutoFixtureExample;
using NUnit.Framework;

namespace CalculatorLibrary.Test.AutoFixureTests
{
    public class DataProcessorTests // показывается как с помощью библиотеки AutoFixture можно создать любой объект
                                    // даже если подразумевается очень большой объект
    {
        private static Fixture _fixture = new Fixture(); // инициализация статического объекта Fixture который помогает создавать значения
        private DataProcessor _systemUnderTests;
        private DataParameters _dataParameters;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new DataProcessor();

            _dataParameters = _fixture
                .Build<DataParameters>()               // AutoFixture создаёт объект класса DataParameters
                                                       // с произвольными значениями для каждого свойства
                
                .With(dp => dp.Mediana, 10M)           // Метод расширения для гибкой настройки параметров класса DataParameters
                .Create();
        }

        [Test]
        public void GIVEN_DataProcessor_WHEN_Process_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Process(_dataParameters);
            NUnit.Framework.Assert.IsNotNull(actual);
            NUnit.Framework.Assert.AreEqual(10M, _dataParameters.Mediana);
        }
    }
}