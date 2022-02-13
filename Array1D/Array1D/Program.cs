using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array1D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for print array : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            // 1D Array
            Console.WriteLine("1D Array");
            int[] arr = new int[n1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = n1;
            }
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.Read();
        }
    }
}
