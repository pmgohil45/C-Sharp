using System;

namespace whileSeries2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1
                1   2
                1   2   3
                1   2   3   4
            */
            Console.WriteLine("Enter a number : ");
            int i = 1, j, n;
            n = Convert.ToInt32(Console.ReadLine());
                
                //i++;
                    
                    while (i <= n)
                    {
                        j = 1;
                        while(j<=i)
                        { 
                            Console.Write(j);
                            j++;
                        }
                        Console.WriteLine();
                        i++;
                    }
                    Console.WriteLine();
                
            Console.Read();
        }
    }
}
