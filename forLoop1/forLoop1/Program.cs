using System;

namespace forLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, nm, j;
            Console.Write("Enter a number : ");
            nm = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= nm; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
