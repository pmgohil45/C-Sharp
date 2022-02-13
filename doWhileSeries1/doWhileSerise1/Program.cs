using System;

namespace doWhileSerise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1 2 3 4 5....
             */
            int i=1, n;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                do
                {
                    Console.Write(i + " ");
                    i++;
                } while (i <= n);
            } while (i == n);
            Console.Read();
        }
    }
}
