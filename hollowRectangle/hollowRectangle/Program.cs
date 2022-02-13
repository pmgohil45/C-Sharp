using System;

namespace hollowRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");;
            int i, j, m, n;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) 
            { 
                for (j = 1; j <= m; j++) 
                {
                    if (i == 1 || i == n || j == 1 || j == m)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
