namespace CalculatorLibrary
{
    public class FakeCalculator : ICalculator
    {
        public decimal Diff(decimal num1, decimal num2) => 1;

        public decimal Divide(decimal num1, decimal num2) => num2 == 0 ? throw new DivideByZeroException() : 2;

        public decimal Multiply(decimal num1, decimal num2) => 6;

        public decimal Sum(decimal num1, decimal num2) => 5;
    }
}
