using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Stergere_valoare
    {
        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k.Se cere sa se stearga din vector
        ///elementul de pe pozitia k.Prin stergerea unui element, toate
        ///elementele din dreapta lui se muta cu o pozitie spre stanga.
        /// </summary>

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Introduceti numarul de elemente: ");
            n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti pozitia de pe care trebuie stearsa valoarea corespunzatoare: ");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] v_final = new int[n - 1];

            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                v[i] = x;
                Console.Write($"{v[i]} ");
            }
            for (int i = 0; i < n-1  ; i++)
            {
                if (i == k)
                   v_final[i] = v[i + 1]; //mutare spre stanga <----
                else
                {
                    if (i < k)
                        v_final[i] = v[i];
                    else
                        v_final[i] = v[i + 1];
                }
                   

            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
                Console.Write($"{v_final[i]} ");
        }
    }
}
