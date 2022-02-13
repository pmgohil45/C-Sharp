using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace electricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 100unit = 10rs per unit
             * 200unit = 15rs per unit
             * 400unit = 20rs per unit
             * 600unit = 25rs per unit
             * 800unit = 30rs per unit
             */
            Console.WriteLine("Enter a unit of electricity bil : ");
            int unit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Rural(Unit:1 to 400) \t 2.Urban(Unit:401 upto)");
            Console.WriteLine("Choose above any one area : ");
            int area = Convert.ToInt32(Console.ReadLine());
            switch (area)
            {
                case 1 :
                    if (unit <= 100)
                    {
                        unit = unit * 10;
                        Console.WriteLine("1. Total Rs. : " + unit);
                    }
                    else if (unit > 100 && unit <= 200)
                    {
                        unit = unit * 15;
                        Console.WriteLine("2 .Total Rs. : " + unit);
                    }
                    else if (unit > 200 && unit <= 400)
                    {
                        unit = unit * 20;
                        Console.WriteLine("3. Total Rs. : " + unit);
                    }
                    else
                    {
                        Console.WriteLine("You are come in Urban area.");
                    }
                    break;

                case 2 :
                    if (unit > 400 && unit <= 600)
                    {
                        unit = unit * 25;
                        Console.WriteLine("4. Total Rs. : " + unit);
                    }
                    else if (unit > 600 && unit <= 800)
                    {
                        unit = unit * 30;
                        Console.WriteLine("5. Total Rs. : " + unit);
                    }
                    else if(unit > 800)
                    {
                        unit = unit * 40;
                        Console.WriteLine("6. Total Rs. : " + unit);
                    }
                    else
                    {
                        Console.WriteLine("You are come in Rural area.");
                    }
                    break;

                default:
                    Console.WriteLine("Dear, You are stay in sky...?");
                    break;
            }

            Console.ReadKey(true);
        }
    }
}
