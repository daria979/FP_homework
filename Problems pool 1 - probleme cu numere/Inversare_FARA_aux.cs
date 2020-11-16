using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Inversare_FARA_aux
    {
        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori 
        /// sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 2 numere de la tastatura: ");
            int a, b;
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Inainte de inversare numerele sunt: ");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Dupa inversare numerele sunt: ");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            Console.WriteLine("observatie: S-a folosit metoda fara a folosi o variabila ajutatoare.");
            Console.ReadKey();
        }
    }
}
