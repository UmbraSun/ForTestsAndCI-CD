using CalculatorLibrary.Loggers;

namespace CalculatorLibrary
{
    public class CalculatorWithDbLogging_Bad : ICalculator // этот пример плох, потому что здесь есть зависимости,
                                                           // создаваемые внутри класса.
                                                           // У нас нет влияния на эти зависимости
    {
        private readonly DbLogger _logger = new DbLogger(); // вот например, там выбрасывается ошибка при попытке лога
                                                            // но в принципе это может быть реальная проблема
                                                            // с записью лога в базу, допустим
                                                            // так же тут стоит модификатор private,
                                                            // который не позволяет добраться до него из теста
                                                            // => эта фигня не поддаётся тестированию

        private readonly ICalculator _calculator = new Calculator(); // и вот, хотя мы знаем, что тут всё в порядке,
                                                                     // так как есть тесты в директории Test

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
