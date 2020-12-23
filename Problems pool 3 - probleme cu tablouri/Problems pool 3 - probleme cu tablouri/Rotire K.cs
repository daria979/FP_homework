using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Rotire_K
    {
        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
        /// </summary>
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("introduceti numarul de elemente: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("introduceti numarul de rotiri: ");
            k = int.Parse(Console.ReadLine());
           
            int[] v = new int[n];
            
             
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                v[i] = x;
                Console.Write($"{v[i]} ");
            }
            
            for (int j=0;j<k;j++) //rotirea se executa de k ori
            {
                int y = v[0]; //memorarea primului element
                for (int i = 1; i < n; i++) 
                {
                     v[i-1] = v[i]; //rotirea spre stanga
                }
                v[n-1] = y; //actualizarea ultimului element cu primul
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
