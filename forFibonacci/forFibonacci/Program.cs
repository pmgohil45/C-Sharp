using System;

namespace forFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int n, i, j, a = 0, b = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(b+"\t");
                    int temp = b;
                    b = a + b;
                    a = temp;
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
