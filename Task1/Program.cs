internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PrepareNumberPoweredMessage(number));
        Console.ReadKey();
    }
    public static string PrepareNumberPoweredMessage(int number)
    {
        int remainder10 = number % 10;
        int remainder100 = number % 100;

        if (
                remainder10 == 0
                || remainder10 >= 5 && remainder10 <= 9
                || remainder100 >= 11 && remainder100 <= 14
            )
        {
            return $"{number} компьютеров";
        }
        else if (remainder10 >= 2 && remainder10 <= 4)
        {
            return $"{number} компьютера";
        }
        else if (remainder10 == 1)
        {
            return $"{number} компьютер";
        }
        else
        {
            throw new Exception($"Message preparing failure: {number}");
        }
    }
}