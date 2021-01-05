using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class INTERCLASARE_vectori_sortati
    {
        static void view(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int [] v1 = { 2, 7, 9, 9, 11 };
            view(v1);
            int [] v2 = { 1, 1, 3, 5, 9, 11, 31};
            view(v2);
            int n = v1.Length;
            int m = v2.Length;
            int[] v3 = new int[n+m];
            int k1 = 0, k2 = 0, k3 = 0;
            
            while(k1<n && k2<m)
            {
                if(v1[k1]<v2[k2])
                {
                    v3[k3] = v1[k1];
                    k3++;
                    k1++;
                }
                else
                {
                    v3[k3] = v2[k2];
                    k3++;
                    k2++;
                }
            }
            while(k1<n)
            {
                v3[k3] = v1[k1];
                k1++;
                k3++;
            }
            while (k2 < m)
            {
                v3[k3] = v2[k2];
                k2++;
                k3++;
            }

            //afisare v3
            Console.WriteLine("interclasarea celor 2 vectori este: ");
            for (int i = 0; i <k3; i++)
                Console.Write($"{v3[i]} ");
            //Console.Write($"{v3[k3]} ");
        }
    }
}
