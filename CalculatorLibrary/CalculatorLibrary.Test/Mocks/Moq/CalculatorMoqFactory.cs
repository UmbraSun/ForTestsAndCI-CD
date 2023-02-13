using Moq;
using System;

namespace CalculatorLibrary.Test.Mocks.Moq
{
    public class CalculatorMoqFactory
    {
        public static ICalculator Order(decimal returnValue) // Моковая библиотека позволяет нам внедрять фейковые объекты в нашу реализацию
        {
            var mock = new Mock<ICalculator>();
            mock.Setup(m => m.Sum(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue); // настройка о том, что если будет вызван метод Sum с любыми значениями,
                                                                                                   // то должен вернуть объект переданный в метод выше
            mock.Setup(m => m.Diff(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
            mock.Setup(m => m.Multiply(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
            mock.Setup(m => m.Divide(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
            mock.Setup(m => m.Divide(It.IsAny<decimal>(), 0)).Throws<DivideByZeroException>(); // а тут должен выкинуть эксепшн
            return mock.Object;
        }

        public static ICalculator Order() // привязывается к конкретным значениям
        {
            var mock = new Mock<ICalculator>();
            mock.Setup(m => m.Sum(2, 3)).Returns(5);
            mock.Setup(m => m.Diff(4, 3)).Returns(1);
            mock.Setup(m => m.Multiply(2, 3)).Returns(6);
            mock.Setup(m => m.Divide(6, 3)).Returns(2);
            mock.Setup(m => m.Divide(6, 0)).Throws<DivideByZeroException>();
            return mock.Object;
        }
    }

    class CalculatorMock : ICalculator // класс который показывает как примерно работают объекты Moq
    {
        public decimal Sum(decimal a, decimal b)
        {
            if (a == 2 && b == 3)
                return 5;

            return default(decimal);
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (a == 6 && b == 3)
                return 2;

            if (a == 6 && b == 0)
                throw new DivideByZeroException();

            return default(decimal);
        }

        public decimal Multiply(decimal a, decimal b)
        {
            if (a == 2 && b == 3)
                return 6;

            return default(decimal);
        }

        public decimal Diff(decimal a, decimal b)
        {
            if (a == 4 && b == 3)
                return 1;

            return default(decimal);
        }
    }
}