public class SumOfSeries
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число N (N > 0):");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("N должно быть больше 0.");
            return;
        }

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }

        Console.WriteLine($"Сумма ряда 1 + 1/2 + 1/3 + ... + 1/{n} равна {sum}");
    }
}