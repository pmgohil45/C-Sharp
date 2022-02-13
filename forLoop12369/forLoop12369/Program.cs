using System;

namespace forLoop12369
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a = 1, b = 2, n = 10;
            Console.Write(a + " ");
            Console.Write(b + " ");
            for (i = 1; i <= n; i++)
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
            }
            Console.Read();
        }
    }
}
