namespace 作業_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxWidth = 9;                     // 最大寬度
            int totalLines = (maxWidth + 1) / 2;    // 根據星號數量，計算總列數

            for (int row = 0; row < totalLines; row++)
            {
                int stars = row * 2 + 1;                // 每列星號數量：依序 1, 3, 5, ...
                int spaces = totalLines - row - 1;        // 每列前置空白數量：使星號置中

                Console.WriteLine(new string(' ', spaces) + new string('*', stars));
            }
            Console.WriteLine("----------------------");
            for (int i = 9; i >= 0; i -= 2)
            {
                Console.WriteLine(new string(' ', (9 - i) / 2) + new string('*', i));
            }

            Console.WriteLine("----------------------");
            int rows = 5;
            for (int i = rows; i >= 1; i--)
            {
                int n = i * 2 - 1;
                for (int j = 1; j <= n; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
