public class BankDeposit
{
    public static void Main(string[] args)
    {
        // Начальный вклад
        double initialDeposit = 1000;

        // Целевая сумма
        double targetDeposit = 1100;

        // Процентная ставка
        Console.Write("Введите процентную ставку (0 < P < 25): ");
        double interestRate = double.Parse(Console.ReadLine());

        // Проверка корректности введенной процентной ставки
        if (interestRate <= 0 || interestRate >= 25)
        {
            Console.WriteLine("Некорректная процентная ставка. Она должна быть в диапазоне от 0 до 25.");
            return;
        }

        // Счетчик месяцев
        int months = 0;

        // Текущий размер вклада
        double currentDeposit = initialDeposit;

        // Цикл, пока размер вклада не превысит целевую сумму
        while (currentDeposit <= targetDeposit)
        {
            // Расчет процентов
            double interest = currentDeposit(interestRate / 100);

            // Обновление размера вклада
            currentDeposit += interest;

            // Увеличение счетчика месяцев
            months++;
        }

        // Вывод результатов
        Console.WriteLine($"Размер вклада превысит 1100 рублей через {months} месяцев.");
        Console.WriteLine($"Итоговый размер вклада: {currentDeposit:F2} рублей.");
    }
}
