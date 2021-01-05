using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class cmmdc_Nnr
    {
        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare
        /// divizor comun al elementelor
        /// </summary>
        /// <param name="args"></param>
        /// 
        //static Random rnd = new Random();

         static int cmmdc_of2(int a, int b)
        {
            //functie care caluleaza cmmdc al 2 numere
            if (a == 0)
                return b;
            if (b == 0)
                return a;


            if (a == b)
                return a;
            if (a > b)
                return cmmdc_of2(a - b, b);
            return cmmdc_of2(a, b - a);
        }

        static void printAllDivisors(int[] v, int n)
        {
            int g = v[0];

           //se retin toti divizorii intr-o lista
            List<int> divisors = new List<int>();

            //se gasesc cmmdc a celor n numere date
            for (int i = 1; i < n; i++)
            {
                g = cmmdc_of2(v[i], g);
            }

            // gaseste toti divzorii CELUI MAI MARE DIVIZOR dupa care ii introduc in lista 

            for (int i = 1; i * i <= g; i++)
            {
                if (g % i == 0)
                {
                    divisors.Add(i);
                    if (g / i != i)
                        divisors.Add(g / i);
                }
            }

            int Cel_mai_mare=0;
            //ACEASTA PROBLEMA POATE AFISA SI TOTI DIVIZORII COMUNI
            foreach (int it in divisors)
                Cel_mai_mare = it;
 
            Console.Write(Cel_mai_mare); //i afisez doar pe ultimul din lista
           
        }
            static void Main(string[] args)
        {

            int[] v = { 12, 24, 8, 6, 20, 34 };
           
            Console.WriteLine("Numerele sunt: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            
            Console.Write("Cel mai mare divizor comun este: ");
            printAllDivisors(v, v.Length);
            Console.WriteLine();
        }
    }
}
