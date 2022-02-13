using System;

namespace forLoopSeries1236
{
    class Program
    {
        static void Main(string[] args)
        {
            //1   2   3   4
            Console.WriteLine("Enter a number : ");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (i = 1; i <= n; i++) {
                for (j = 1; j <= i; j++) {
                    Console.Write(sum + " ");
                    sum += i * (i + 1) / 2;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
