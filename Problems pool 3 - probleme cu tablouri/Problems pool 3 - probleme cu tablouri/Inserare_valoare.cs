using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Inserare_valoare
    {
        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
        /// Se cere sa se insereze valoarea e in vector pe pozitia k.Primul element al vectorului se
        /// considera pe pozitia zero.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Problema o abordam in felul urmator:
            //Ne vom folosi de un al doilea vector in care vom afisa vectorul v si valoarea e pe pozitia k 
            //mutand toate celelate elemente de dupa valoarea e ale evctorului cu o pozitie inspre DREAPTA
            int n, e, k;
            Console.WriteLine("Introduceti numarul de elemente: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea care trebuie inserata: ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia pe care trebuie inserata valoarea de mai sus: ");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] v_final = new int[n + 1];

            for(int i=0;i<n;i++)
            {
                int x = rnd.Next(10);
                v[i] = x;
                Console.Write($"{v[i]} ");
            }
            for(int i=0;i<n+1;i++)
            {
                if (i < k)
                    v_final[i] = v[i];
                else
                {
                    if (i == k)
                        v_final[i] = e;
                    else
                        v_final[i] = v[i-1]; //mutare spre dreapta ---->
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n + 1; i++)
                Console.Write($"{v_final[i]} ");
        }
    }
}
