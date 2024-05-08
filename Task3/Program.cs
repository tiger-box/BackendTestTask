using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] print = ReturnArray(11, 20);
        for (int i = 0; i < print.Length; i++)
        {
            Console.WriteLine("{0}", print[i]);
        }
    }

    public static int[] ReturnArray(int min, int max)
    {
        List<int> result = new List<int>();

        for (int i = min; i <= max; i++)
        {
            if (IsPrime(i))
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
    public static bool IsPrime(int number) 
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }
            return true; 
    }


}