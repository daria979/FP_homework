using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Rotire_crescatoare
    {
        /// <summary>
        /// O (secventa crescatoare rotita) este o secventa de numere care este in ordine crescatoare 
        /// sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire = primul element devine ultimul). 
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita.
        /// </summary>
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            int n;
            Console.Write($"Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere de la tastatura: ");
            int x = int.Parse(Console.ReadLine());
            int first = x;
            bool ok = false;
            int attempts = 0;
            for (int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                int last = y;
                if (x < y)
                    ok = true;
                else
                {
                    attempts++;
                    if (attempts == 1 && first > last)
                        ok = true;
                    else
                    {
                        ok = false;
                        break;
                    }
                }

                x = y;

            }
            if (ok == true)
                Console.WriteLine("Secventa este crescatoare rotita!");
            else
                Console.WriteLine("Secventa NU este crescatoare rotita!");

        }
    }
}
