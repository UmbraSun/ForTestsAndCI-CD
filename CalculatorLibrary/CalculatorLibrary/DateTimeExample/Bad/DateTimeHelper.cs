namespace CalculatorLibrary.DateTimeExample.Bad
{
    static class DateTimeHelper // для Helper методов обычно нельзя написать Moq тестов
                                // поэтому это считается плохой практикой
    {
        public static DateTime GetCurrentDateTime() => DateTime.Now;
    }
}
