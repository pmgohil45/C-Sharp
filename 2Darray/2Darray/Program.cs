using System;

namespace _2Darray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for print array : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = new int[n1, n2];
            int i1, j1;
            for (i1 = 1; i1 <= n1; i1++)
            {
                for (j1 = 1; j1 <= n2; j1++)
                {
                    Console.Write(j1 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
