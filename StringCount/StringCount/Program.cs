namespace StringCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            int count = 1;
            int currentIndex = 0;
            bool hasdouble = false;

            for (int i = currentIndex+1; i < chars.Length; i++)
            {
                if (chars[i] == chars[currentIndex])
                {
                    count++;
                    hasdouble = true;
                }
                else
                {
                    if (count > 1)
                    {
                        Console.WriteLine($"The character {chars[currentIndex]} appears {count} times.");
                    }
                    currentIndex = i;
                    count = 1;
                }
            }
            if (count > 1)
            {
                Console.WriteLine($"The character {chars[currentIndex]} appears {count} times.");
            }
            else if(!hasdouble)
            {
                Console.WriteLine("no reoccurrence");
            }

        }
    }
}
