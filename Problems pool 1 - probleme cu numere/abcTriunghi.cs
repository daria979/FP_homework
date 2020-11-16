using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class abcTriunghi
    {
        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi 
        /// lungimile laturilor unui triunghi.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere care vor reprezenta laturile unui posibil triunghi: ");
            int a, b, c;
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = int.Parse(Console.ReadLine());

            //Ne vom folosi de inegalitatea triunghiului:
            //Suma a doua lungimi de laturi sa fie mai mica sau egala decat cea de a 3-a latura

            if ((a <= b + c) && (b <= a + c) && (c <= a + b))
                Console.WriteLine($"Laturile de lungime {a}, {b} si {c} pot forma un triunghi.");
            else
                Console.WriteLine($"Laturile de lungime {a}, {b} si {c} NU pot forma un triunghi.");
            Console.ReadKey();
        }
    }
}
