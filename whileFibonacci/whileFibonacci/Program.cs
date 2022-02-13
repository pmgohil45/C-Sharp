using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whileFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0, n2=1, n3, count, i = 2;
            Console.Write("Enter a number : ");
            count = Convert.ToInt32(Console.ReadLine());
            while (i != count) {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n2 = n1;
                n1 = n3;
                i++;
            }
            Console.Read();
        }
    }
}
