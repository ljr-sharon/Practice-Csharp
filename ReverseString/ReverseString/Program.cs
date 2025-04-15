namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array.reverse
            //Console.WriteLine("輸入英文句子：");
            //string input = Console.ReadLine();
            //var chars = input.ToCharArray();
            //Array.Reverse(chars);
            //Console.WriteLine("反轉後的句子：");
            //Console.WriteLine(chars);

            // 反轉字串
            Console.WriteLine("輸入英文句子：");
            string input =  Console.ReadLine() ;
            char[] chars = input.ToCharArray();

            for (int i = chars.Length-1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }


        }
    }
}
