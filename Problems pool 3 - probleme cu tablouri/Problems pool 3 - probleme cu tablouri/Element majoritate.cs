using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Element_majoritate
    {
        /// <summary>
        /// (Element majoritate). 
        /// Intr-un vector cu n elemente, un
        /// element m este element majoritate daca mai mult de n/2 din
        /// valorile vectorului sunt egale cu m(prin urmare, daca un
        /// vector are element majoritate acesta este unui singur). Sa se
        /// determine elementul majoritate al unui vector(daca nu
        /// exista atunci se va afisa<nu_exista>). (incercati sa gasiti o
        /// solutie liniara).
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n=100;
            //n = rnd.Next(5, 21);
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                int x = rnd.Next(0, 2); //pt a avea precizie mai mare
                v[i] = x;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
            int mid = n / 2;
            int[] aparitii = new int[n];
            int j = 0;
            while(j<n)
            {
                aparitii[v[j++]]++;
            }
            bool ok = false;
            for(int i=0;i<n;i++)
            {
                if(aparitii[i]>mid)
                {
                    Console.WriteLine($"{i} este numarul majoritar!");
                    ok = true;
                    break;
                }
            }
            if(ok==false)
            {
                Console.WriteLine($"nu exista");
            }
            Console.WriteLine();
        }
    }
}
