using CalculatorLibrary.Loggers;

namespace CalculatorLibrary
{
    public class CalculatorWithDbLogging_Ok : ICalculator
    {
        private readonly ILogger _logger;
        private readonly ICalculator _calculator;

        public CalculatorWithDbLogging_Ok(ILogger logger, ICalculator calculator) // только в этом отличие от Bad класса
                                                                                  // как раз из-за зависимостей
                                                                                  // позволяется заменять объекты на моковые
        {
            _logger = logger;
            _calculator = calculator;
        }

        public decimal Sum(decimal a, decimal b)
        {
            _logger.Log("Sum operation.");
            return _calculator.Sum(a, b);
        }

        public decimal Divide(decimal a, decimal b)
        {
            _logger.Log("Divide operation.");
            return _calculator.Divide(a, b);
        }

        public decimal Multiply(decimal a, decimal b)
        {
            _logger.Log("Multiply operation.");
            return _calculator.Multiply(a, b);
        }

        public decimal Diff(decimal a, decimal b)
        {
            _logger.Log("Diff operation.");
            return _calculator.Diff(a, b);
        }
    }
}