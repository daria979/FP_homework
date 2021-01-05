using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Operatii_cu_multimi
    {
        /// <summary>
        /// Operatii cu multimi: reuniune, intersectie, diferenta
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Cu vectori de frecventa
            int n, m, p, q;
            n = 8;
            m = 8;
            p = 30;
            q = 30;
            int[] A = new int[n];
            int[] B = new int[m];
            int[] C = new int[m + n];
            int[] A1 = new int[p];
            int[] B1 = new int[q];
            A[0] = rnd.Next(5);
            B[0] = rnd.Next(5);
            Console.Write("Multimea A: ");
            Console.Write(A[0] + " ");
            for (int i = 1; i < n; i++)
            {
                A[i] = rnd.Next(5) + A[i - 1] + 1;
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Multimea B: ");
            Console.Write(B[0] + " ");
            for (int i = 1; i < m; i++)
            {
                B[i] = rnd.Next(5) + B[i - 1] + 1; //pentru a nu se repeta valorile intr-un vector
                Console.Write(B[i] + " ");
            }

            for (int i = 0; i < p; i++)
                A1[i] = 0;

            for (int i = 0; i < q; i++)
                B1[i] = 0;

            for (int i = 0; i < n; i++)
                A1[A[i]]++;

            for (int i = 0; i < m; i++)
                B1[B[i]]++;
            Console.WriteLine();

            
            Console.WriteLine();
            Console.WriteLine("Reuniunea: ");
            for (int i = 0; i < p; i++)
            {
                if (A1[i] != 0 || B1[i] != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("intersectia: ");
            for (int i = 0; i < p; i++)
            {
                if (A1[i] != 0 && B1[i] != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("A/B: ");
            for (int i = 0; i < p; i++)
            {
                if (A1[i] != 0 && B1[i] == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("B/A: ");
            for (int i = 0; i < q; i++)
            {
                if (A1[i] == 0 && B1[i] != 0)
                    Console.Write(i + " ");
            }
        }
    }
       
}
