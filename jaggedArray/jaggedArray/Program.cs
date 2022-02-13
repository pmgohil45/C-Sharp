using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged Array");
            int[][] jarr = new int[3][];
            jarr[0] = new int[] { 1, 2, 3, 4 };
            jarr[1] = new int[] { 1, 2, 3 };
            jarr[2] = new int[] { 1, 2 };

            for (int i = 0; i < jarr.Length; i++)
            {
                Console.Write("Row : " + i);
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write("Column : " + jarr[i][j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
