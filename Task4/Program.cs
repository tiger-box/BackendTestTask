internal class Program
{
    private static void Main(string[] args)
    {
        multiplicationTable(5);
    }

    public static void multiplicationTable(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                if (i == 0 && j == 1) Console.Write("\t");
                else if (i != 0 && j == 1) Console.Write(i + "\t");

                if (i > 0) Console.Write(i * j + "\t");
                else Console.Write(j + "\t");
            }
            Console.Write("\n");
        }

    }
}

