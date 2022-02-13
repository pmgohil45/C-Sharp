using System;

namespace forLoopSeries2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int i = 1, j = 1, n;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = i; j <= i; j++) {
                    Console.Write(j);
                }
               // Console.WriteLine();
            }
            Console.Read();
        }
    }
}
