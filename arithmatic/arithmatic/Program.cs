using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arithmatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum;
            
            sum = n1+n2;
            Console.WriteLine("Addition : " + sum);
            sum = n1 - n2;
            Console.WriteLine("Subtraction: " + sum);
            sum = n1 * n2;
            Console.WriteLine("Multiplication : " + sum);
            sum = n1 / n2;
            Console.WriteLine("Division : " + sum);

            Console.Read();
        }
    }
}
