
namespace CalculatorLibrary
{
    public class Calculator : ICalculator
    {
        public decimal Sum(decimal num1, decimal  num2) => num1 + num2;

        public decimal Diff(decimal num1, decimal num2) => num1 - num2;

        public decimal Multiply(decimal num1, decimal num2) => num1 * num2;
        
        public decimal Divide(decimal num1, decimal num2) => num1 / num2;
    }
}