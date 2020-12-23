using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Reverse
    {
        /// <summary>
        /// Reverse. 
        /// Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti numarul de elemente: ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            int[] k = new int[n];
            for(int i=0;i<n;i++)
            {
                int x = rnd.Next(10);
                v[i] = x;
                Console.Write($"{v[i]} ");
            }
            int p = 1;
            for(int i=0;i<n;i++)
            {
                k[i] = v[n - p];
                p++;
            }
            Console.WriteLine();
            for(int i=0;i<n;i++)
            {
                Console.Write($"{k[i]} ");

            }
        }   
     

    }
}
