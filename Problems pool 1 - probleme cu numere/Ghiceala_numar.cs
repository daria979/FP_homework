using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Ghiceala_numar
    {
        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari 
        /// de forma "numarul este mai mare sau egal decat x?".
        /// </summary>
        /// <param name="args"></param>

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intre 1 si 1024: ");
            int x, n;
           

            try
            {
                Console.Write("x: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                    throw new Exception("Nu ati introdus un numar !");


                bool ok=false;
                while (!ok)
                {
                    ok = false;
                    n = rnd.Next(1, 1025);
                    Console.Write($"numarul {n} este mai mare sau egal decat {x}?");
                    if (n >= x)
                    {
                        ok = true;
                        Console.Write(" DA!");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.Write(" NU!");
                        Console.WriteLine();
                        continue;
                    }

                     
                }

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
