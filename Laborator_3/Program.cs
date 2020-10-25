using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices.ComTypes;

namespace Reuniune
{
    /// <summary>
    /// Operatii cu multimi in 2 metode
    /// Tema - adunarea a doua numere repezentate ca si vectori de cifre (in baza 10)
    /// </summary>
    class Program
    {
        static Random rnd = new Random();

        static void Metoda1()
        {
            int n, m;
            n = 8; m = 8;
            int[] A = new int[n];
            int[] B = new int[m];

            A[0] = rnd.Next(5);
            B[0] = rnd.Next(5);
            Console.WriteLine("Afisarea celor 2 multimi:");
            Console.Write("A --> ");

            Console.Write(A[0] + " ");

            for (int i = 1; i < n; i++)
            {
                A[i] = rnd.Next(5) + A[i - 1] + 1;
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("B --> ");

            Console.Write(B[0] + " ");
            for (int i = 1; i < m; i++)
            {
                B[i] = rnd.Next(5) + B[i - 1] + 1;
                Console.Write(B[i] + " ");
            }

            Console.WriteLine();

            /// Intersectia
            int[] C = new int[n + m];
            int idx = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i] == B[j])
                    {
                        C[idx] = A[i];
                        idx++;
                    }
                }
            }
            Console.WriteLine("Intersectia: ");
            for (int i = 0; i < idx; i++)
            {
                Console.Write(C[i] + " ");
            }
            /// Reuniunea
            idx = 0;
            for (int i = 0; i < n; i++)
            {
                C[idx] = A[i];
                idx++;
            }
            for (int i = 0; i < m; i++)
            {
                bool okay = true;
                for (int j = 0; j < idx; j++)
                {
                    if (B[i] == C[j])
                    {
                        okay = false;
                        break;
                    }
                }
                if (okay)
                {
                    C[idx] = B[i];
                    idx++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Reuniunea: ");
            for (int i = 0; i < idx; i++)
            {
                Console.Write(C[i] + " ");
            }

            /// Concatenare
            idx = 0;
            for (int i = 0; i < n; i++)
            {
                C[idx] = A[i];
                idx++;
            }
            for (int i = 0; i < m; i++)
            {
                C[idx] = B[i];
                idx++;
            }

            Console.WriteLine();
            Console.WriteLine("Concatenarea: ");

            for (int i = 0; i < idx; i++)
            {
                Console.Write(C[i] + " ");
            }

            /// A / B
            idx = 0;
            for (int i = 0; i < n; i++)
            {
                bool okay = true;
                for (int j = 0; j < m; j++)
                {
                    if (A[i] == B[j])
                    {
                        okay = false;
                    }
                }
                if (okay)
                {
                    C[idx] = A[i];
                    idx++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("A/B: ");

            for (int i = 0; i < idx; i++)
            {
                Console.Write(C[i] + " ");
            }

            /// B / A
            idx = 0;
            for (int i = 0; i < m; i++)
            {
                bool okay = true;
                for (int j = 0; j < n; j++)
                {
                    if (A[j] == B[i])
                    {
                        okay = false;
                    }
                }
                if (okay)
                {
                    C[idx] = B[i];
                    idx++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("B/A: ");

            for (int i = 0; i < idx; i++)
            {
                Console.Write(C[i] + " ");
            }

            /// Interclasare
            int k1, k2;
            idx = 0;
            k1 = 0;
            k2 = 0;

            while (k1 < n && k2 < m)
            {
                if (A[k1] < B[k2])
                {
                    C[idx] = A[k1];
                    idx++;
                    k1++;
                }
                else
                {
                    C[idx] = B[k2];
                    idx++;
                    k2++;
                }
            }

            while (k1 < n)
            {
                C[idx] = A[k1];
                idx++;
                k1++;
            }

            while (k2 < m)
            {
                C[idx] = B[k2];
                idx++;
                k2++;
            }

            Console.WriteLine();
            Console.WriteLine("Interclasarea: ");

            for (int i = 0; i < idx; i++)
            {
                Console.Write(C[i] + " ");
            }


            Console.ReadKey();
        }

        static void Metoda2()
        {
            //Cu vectori de frecventa
            int n, m,p,q;
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
            Console.Write(A[0]+" ");
            for (int i=1;i<n;i++)
            {
                A[i] = rnd.Next(5) + A[i - 1] + 1;
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Multimea B: ");
            Console.Write(B[0]+" ");
            for (int i = 1; i < m; i++)
            {
                B[i] = rnd.Next(5) + B[i - 1] + 1;
                Console.Write(B[i] + " ");
            }

            for(int i=0;i<p;i++)
                A1[i] = 0;
            
            for (int i = 0; i < q; i++)
                B1[i] = 0;

            for (int i = 0; i < n; i++)
                A1[A[i]]++;

            for (int i = 0; i < m; i++)
                B1[B[i]]++;
            Console.WriteLine();

            /*for (int i = 0; i < p; i++)
                Console.Write(A1[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < q; i++)
                Console.Write(B1[i] + " ");*/
            Console.WriteLine();
            Console.WriteLine("Reuniunea: ");
            for(int i=0;i<p;i++)
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
        }

        static void Tema()
        {
            int a, b, nr1, nr2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            nr1 = a;
            nr2 = b;
            int cifre_a = 0, cifre_b = 0;

            while (a > 0)
            {
                cifre_a++;
                a = a / 10;
            }
            while (b > 0)
            {
                cifre_b++;
                b = b / 10;
            }

            int[] V1 = new int[cifre_a];
            int[] V2 = new int[cifre_b];



            for (int i = cifre_a - 1; i >= 0; i--)
            {
                V1[i] = nr1 % 10;
                nr1 = nr1 / 10;
            }
            for (int i = cifre_b - 1; i >= 0; i--)
            {
                V2[i] = nr2 % 10;
                nr2 = nr2 / 10;
            }

            int max = 0;
            if (cifre_a == cifre_b)
            {
                  max = cifre_a;
            }
            else
            {
                if (cifre_a > cifre_b)
                    max = cifre_a;
                else
                    max = cifre_b;
            }
           // Console.Write(max);
           
            int[] Suma = new int[max];

            int n = V1.Length;
            int m = V2.Length;
            //Console.Write(n);
            //Console.Write(m);
            int[] Nr_new1 = new int[m];
            int[] Nr_new2 = new int[n];

            if (n < m)
            {
                int k = m - n;
                int x = k;
                for (int i = 0; i < m; i++)
                    if (i < k)
                        Nr_new1[i] = 0; //complectam cu 0 pozitiile

                for (int i = 0; i < n; i++)
                    Nr_new1[x++] = V1[i];


                int t = 0;
                for (int i = 0; i < max; i++)
                {

                    Suma[i] = Nr_new1[i] + V2[i] + t;

                    t = Suma[i] / 10;        //transportul pentru urmatoarea adunare

                    Suma[i] = Suma[i] % 10;  //pastram doar ultima cifra a sumei
                                            
                }
                //daca la sfarsit avem transport diferit de zero il adagam la suma

                if (t > 0)

                    Suma[max++] = t;


            }
            else
            {
                int k = n - m;
                int x = k;
                for (int i = 0; i < n; i++)
                    if (i < k)
                        Nr_new2[i] = 0;

                for (int i = 0; i < m; i++)
                    Nr_new2[x++] = V2[i];

                int t = 0; 
                for (int i=0;i < max; i++)
                {

                    Suma[i] = Nr_new2[i] + V1[i] + t;

                    t = Suma[i] / 10;        //transportul pentru urmatoarea adunare

                    Suma[i] = Suma[i] % 10;  //pastram doar ultima cifra a sumei

                }

                //daca la sfarsit avem transport diferit de zero il adagam la suma

                if (t > 0)

                    Suma[max++]= t;
                

            }

            if (n == m)
            {
                int t = 0;
                for (int i = 0; i < max; i++)
                {

                    Suma[i] = V2[i] + V1[i] + t;

                    t = Suma[i] / 10;        //transportul pentru urmatoarea adunare

                    Suma[i] = Suma[i] % 10;  //pastram doar ultima cifra a sumei

                }

                //daca la sfarsit avem transport diferit de zero il adagam la suma

                if (t > 0)

                    Suma[max++] = t;

            }
            
            for (int i = 0; i < max; i++)
                Console.Write(Suma[i] + " ");


        }
        static void Main(string[] args)
        {
            Tema();
        }

    }
    
}