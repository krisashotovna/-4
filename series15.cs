public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число K:");
        int k = int.Parse(Console.ReadLine());

        int number = 1;
        int firstLarger = 0;

        Console.WriteLine("Введите набор целых чисел (0 для завершения):");

        while (true)
        {
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }

            if (input > k && firstLarger == 0)
            {
                firstLarger = number;
            }

            number++;
        }

        Console.WriteLine("Номер первого числа, большего K: " + firstLarger);
    }
}