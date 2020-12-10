using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Min_Max
    {
        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si
        /// cel mai mare element al vectorului.Pentru extra-credit realizati programul 
        /// efectuand 3n/2 comparatii (in cel mai rau caz).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int poz1 = 0;
            int min = v[0];
            int max = v[0];
            int poz2 = 0;
            for(int i=0;i<n;i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    poz1 = i;
                }   
                if(v[i]>max)
                {
                    max = v[i];
                    poz2 = i;
                }
                    poz2 = i;
            }
            Console.WriteLine($"Minimul se afla pe pozitia {poz1} \n Maximul se afla pe pozitia {poz2}");
        }
    }
}
