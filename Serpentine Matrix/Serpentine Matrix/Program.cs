namespace Serpentine_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);
            int rowStart = 1;     // 每一列的起始數字

            for (int i = 1; i <= N; i++)
            {
                if (i == 1)
                {
                    rowStart = 1;
                }
                else
                {
                    rowStart += (i - 1); // 起始纍加
                }

                // rowStart 為起點
                int current = rowStart;
                int count = N - i + 1; // 要印的數字個數

                for (int j = 1; j <= count; j++)
                {
                    // 印出當前數字（每列的第 j 個數）
                    Console.Write(current);

                    // 若非本列最後一個數字，印出後方空格
                    if (j < count)
                        Console.Write(" ");

                    // 下一個數字 = current + (i + j)
                    current += (i + j);
                }

                // 列尾換行
                Console.WriteLine();
            }

            Console.WriteLine("---------------------");
            
            int nextCurrent = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = N - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                // 第 i 列印 i 個數字
                for (int K = 1; K <= i; K++)
                {
                    Console.Write(nextCurrent);
                    // 非本列最後一個數字 印出後方空格
                    if (K < i)
                    {
                        Console.Write(" ");
                    }
                    nextCurrent++;  // 將 current 遞增 印出下一個數字
                }

                Console.WriteLine();

            }
        }
    }
}
