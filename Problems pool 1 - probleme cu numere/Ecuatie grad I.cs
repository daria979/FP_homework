using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Ecuatie_grad_I
    {
        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, 
        /// unde a si b sunt date de intrare.
        /// </summary>
        /// <param name="args"></param>
         static void Main(string[] args)
        {
            float a, b, x;

            Console.Write("Introduceti un numar a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b: ");
            b = float.Parse(Console.ReadLine());

            x = -b / a;

            Console.Write($"Ecuatia de gradul I formata este: {a}x + {b}");
            Console.WriteLine();
            Console.Write($"Necunoscuta x este egala cu: {x}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
