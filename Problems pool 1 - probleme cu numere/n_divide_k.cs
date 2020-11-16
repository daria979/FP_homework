using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class n_divide_k
    {
        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Verificare daca un numar il divide pe celalalt.");
            int n, k;
            Console.Write("Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}.");
            else
                Console.WriteLine($"{n} NU se divide cu {k}.");
            Console.ReadKey();
        }
    }
}
