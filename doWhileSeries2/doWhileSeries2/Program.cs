using System;

namespace doWhileSeries2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               1
               1   2
               1   2   3
               1   2   3   4
           */
            Console.WriteLine("Enter a number : ");
            int i = 1, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            //i++;

            do
            {
                j = 1;
                do
                {
                    Console.Write(j);
                    j++;
                } while (j <= i);
                Console.WriteLine();
                i++;
            } while (i <= n);
            Console.WriteLine();

            Console.Read();
        }
    }
}
