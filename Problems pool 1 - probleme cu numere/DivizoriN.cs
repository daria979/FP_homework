using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class DivizoriN
    {
        /// <summary>
        /// Afisati toti divizorii numarului n.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg de la tastaura: ");
            int n, d;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Toti divizorii intregi ai numarului n sunt: ");
            for(d=1;d<=n;d++)
            {
                if (n % d == 0)
                    Console.Write($"{-d},{d},");
            }

            Console.ReadKey();
        }
    }
}
