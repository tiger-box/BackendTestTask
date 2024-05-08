internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 42, 12, 18 };

        int[] ptint = InputArray(numbers);
        for (int i = 0; i < ptint.Length; i++)
        {
            Console.WriteLine(ptint[i]);
        }
    }

    public static int[] InputArray(int[] array)
    {
        List<int> result = new List<int>();
        int min = array.Min();
        int[] arrayWithoutMin = array.Where(val => val != min).ToArray();

        int step = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                step = 2;
                break;
            }
        }

        if (step == 1) result.Add(2);

        for (int i = 3; i <= Convert.ToInt32(min / 2) ; i += step)
        {
            if (min % i == 0 ) result.Add(i);
        }

        result.Add(min);

        for (int i = 1; i < result.Count; i++)
        {
            for (int j = 0; j < arrayWithoutMin.Length; j++)
            {
                if (arrayWithoutMin[j] % result[i] != 0)
                {
                    result.RemoveAt(i);
                    break;
                }
            }
        }

        return result.ToArray();
    }
}