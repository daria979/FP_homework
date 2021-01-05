using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class from10baseTOanotherBase
    {
        static string ten_TO_xbase(int numar, int bazaTinta)
        {

            int cat, rest;

            string result = "";
            Stack<int> stiva = new Stack<int>();

            while (numar > 0)
            {
                cat = numar / bazaTinta;
                rest = numar % bazaTinta;

                stiva.Push(rest);

                numar = numar / bazaTinta;
            }


            string[] hex = { "A", "B", "C", "D", "E", "F" };
            while (stiva.Count > 0)
            {
                int cifra = stiva.Pop();
                if (cifra >= 10)
                {
                    // metoda 1 - folosind ASCII
                    //cifra += 55;
                    //result = result + (char)cifra;

                    // metoda 2 - folosind un Array cu valorile
                     result = result + hex[cifra - 10];
                }
                else
                {
                    result = result + cifra;
                }
            }

            return (result);
        }
        /// <summary>
        /// Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se
        /// converteasca si sa se afiseze
        /// numarul n in baza b.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n, b;
            Console.WriteLine("Introduceti un numar in baza 10: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza tinta de convertire a numarului: ");
            b = int.Parse(Console.ReadLine());

            //afisar rezultat
            Console.WriteLine($"Numarul {n} in baza {b} este: {ten_TO_xbase(n, b)} ");
        }
    }
}
