using System;

namespace whileSeries12369
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, a = 1, b = 2, n;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " ");
            Console.Write(b + " ");
            while (i <= n)
            {
                if (i % 2 == 1)
                {
                    a = a * 3;
                    Console.Write(a + " ");
                }
                else
                {
                    b = b * 3;
                    Console.Write(b + " ");
                }
                i++;
            }
            Console.Read();
        }
    }
}
