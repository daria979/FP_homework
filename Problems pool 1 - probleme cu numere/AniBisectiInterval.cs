using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class AniBisectiInterval
    {
        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static bool is_bisect(int y)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doi ani (numare naturale) de la tastatura: ");
            int y1, y2, nr = 0;

            try
            {
                Console.Write("primul an: ");
                if (!int.TryParse(Console.ReadLine(), out y1))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write("al doilea an: ");
                if (!int.TryParse(Console.ReadLine(), out y2))
                    throw new Exception("Nu ati introdus un numar !");

                if (y1 == y2)
                {
                    throw new Exception("Nu aveti un interval de numere intregi!");
                }
                else if (y1 < y2)
                {
                    for (int i = y1; i <= y2; i++)
                    {
                        if (is_bisect(i))
                            nr++;
                    }
                    Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti");

                }
                else
                {
                    for (int i = y2; i <= y1; i++)
                    {
                        if (is_bisect(i))
                            nr++;
                    }
                    Console.WriteLine($"Intre anii {y2} si {y1} sunt {nr} ani bisecti");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
