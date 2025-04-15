namespace Numbers_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 38, 12, 65, 42, 21, 74 };
            for (int i = 0; i < numbers.Length; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }

                }
                if (maxIndex != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[maxIndex];
                    numbers[maxIndex] = temp;
                }

                Console.Write(numbers[i] + ",");
            }
        }
    }
}
