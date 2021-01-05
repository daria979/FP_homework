using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Ordine_Lexicografica
    {
        /// <summary>
        /// Se dau doi vectori. Se cere sa se determine ordinea lor
        /// lexicografica(care ar trebui sa apara primul in dictionar).
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();

        static void view(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }   
        static void Comparare()
        {
            int n, m;
            n = rnd.Next(2, 10);
            m = rnd.Next(2, 10);
            int min = Math.Min(n, m);
            int[] v1 = new int[n];
            int[] v2 = new int[m];

            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(1, 10);
                v1[i] = x;
            }
            for (int i = 0; i < m; i++)
            {
                int x = rnd.Next(1, 10);
                v2[i] = x;
            }

            //se vor ocmpara valorile pana la numarul minim de elemente ale unui vector
            //vectorul cu valori minime este v1
            for (int i = 0; i < min - 1; i++)
            {
                if (v1[i] < v2[i])
                {
                        if (v1[i] == v2[i])
                            continue;
                        else
                        {
                            view(v1);
                            view(v2);
                            break;
                        }
                            

                }
                else
                {
                    view(v2);
                    view(v1);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Ordinea lexicografica este urmatoarea: ");
            Comparare();
        }
    }
}
