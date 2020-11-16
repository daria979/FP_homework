using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class InversareValori
    {
        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 2 numere de la tastatura:");
            int a, b;
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Inainte de inversare numerele sunt: ");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            int aux;
            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Dupa inversare numerele sunt: ");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            Console.ReadKey();
        }
    }
}
