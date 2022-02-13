using System;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else
            int i, nm, j;
            Console.Write("Enter a number : ");
            nm = Convert.ToInt32(Console.ReadLine());
            if (nm >= 0)
            {
                Console.Write("above zero");
            }
            else
            {
                Console.Write("bellow zero");
            }
            Console.Read();
        }
    }
}
