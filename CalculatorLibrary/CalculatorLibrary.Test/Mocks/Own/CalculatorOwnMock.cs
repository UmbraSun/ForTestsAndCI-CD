namespace CalculatorLibrary.Test.Mocks.Own
{
    class CalculatorOwnMock : ICalculator // класс который всегда возвращает в тест 0 или ошибку DivideByZeroException
    {
        public decimal Sum(decimal a, decimal b) => 0;

        public decimal Diff(decimal a, decimal b) => 0;

        public decimal Multiply(decimal a, decimal b) => 0;

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return 0;
        }
    }
}
