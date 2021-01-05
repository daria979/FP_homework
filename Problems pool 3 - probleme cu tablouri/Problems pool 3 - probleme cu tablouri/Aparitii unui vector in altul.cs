using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Aparitii_unui_vector_in_altul
    {
        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector
        /// p(vectorul care se cauta). Determinati de cate ori apare p in
        /// s.De ex.Daca s = [1, 2, 1, 2, 1, 3, 1, 2, 1] si p = [1, 2, 1] atunci p apare in s de 3 ori.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();

        static void view(int []v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }
        static int Verificare_apartenenta()
        {
            int n, m; //dimensiunile vectorului cu n>m, random
            n = rnd.Next(10, 21);
            m = rnd.Next(2, 4);
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            //initializarea celor 2 vectori (cu valori random)
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(0, 10);
                v1[i] = x;
            }
            view(v1);
            for (int i = 0; i < m; i++)
            {
                int x = rnd.Next(0, 11);
                v2[i] = x;
            }
            view(v2);
            bool ok = false, okg = false;
            int nr_aparitii = 0;
            for (int i = 0; i < n - m; i++)
            {
                if (v1[i] == v2[0])
                {
                    ok = true;
                    for (int j = 1; j < m; j++)
                        if (v1[j + 1] != v2[j])
                            ok = false;
                    if (ok == true)
                        okg = true;
                }
                else
                    continue;
                if (okg == true)
                    nr_aparitii++;
            }
            return nr_aparitii;
        }
        static void Main(string[] args)
        {
            Console.Write($"Al doilea vector apare in primul de {Verificare_apartenenta()} ori");
            Console.WriteLine();
        }
    }
}
