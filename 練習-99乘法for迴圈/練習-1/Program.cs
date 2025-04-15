namespace 練習_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            int a;

            for (int i = 1; i <10; i++)
            {
               
                for (int j = 1; j <10; j++)
                { 
                    a= i * j;
                    Console.Write(j+"*"+i+"="+a );

                    if (j == 9)
                        Console.Write("\n");
                    else
                        Console.Write("\t");
                    
                }   
            }
            
           


        }
    }
}
