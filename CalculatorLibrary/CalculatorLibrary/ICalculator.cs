using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface ICalculator
    {
        public decimal Sum(decimal num1, decimal num2);

        public decimal Diff(decimal num1, decimal num2);

        public decimal Multiply(decimal num1, decimal num2);

        public decimal Divide(decimal num1, decimal num2);
    }
}
