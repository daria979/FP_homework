using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Monotonie_secventa
    {
        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la tastatura (cat mai mici, pentru rezultate mai exacte): ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                
                int nr_cresc = 0;
                int nr_descresc = 0;
                int x = rnd.Next(21);

                Console.WriteLine("Secventa data este: ");
                Console.Write($"{x} ");
                for (int i = 0; i < n-1; i++)
                {
                    int y = rnd.Next(21);
                    Console.Write($"{y} ");

                    if (x<y)
                        nr_cresc++;
                    else
                        if (y<x)
                            nr_descresc++;

                    x = y;

                }

                Console.WriteLine();

                if (nr_cresc > 0 && nr_descresc == 0)
                    Console.WriteLine("Secvena data este MONOTON crescatoare.");
                if (nr_cresc == 0 && nr_descresc > 0)
                    Console.WriteLine("Secvena data este MONOTON descrescatoare.");
                if (nr_cresc > 0 && nr_descresc > 0)
                    Console.WriteLine("Secvena data NU are MONOTONIE.");

                Console.WriteLine();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
