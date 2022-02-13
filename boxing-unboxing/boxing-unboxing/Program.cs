using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object o = a; //boxing
            Console.WriteLine("Boxing : " + a);
            Console.WriteLine("Object : " + o);

            int b = (int)o;//unboxing
            Console.WriteLine("Unboxing : " + b);
            Console.ReadLine(); 
        }
    }
}
