using System;

namespace whileSeries1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int i=1, n;
            n = Convert.ToInt32(Console.ReadLine());
            while (i == 1) {
                while(i<=n){
                    Console.Write(i + " ");
                    i++;
                }
            }
            Console.Read();
        }
    }
}
