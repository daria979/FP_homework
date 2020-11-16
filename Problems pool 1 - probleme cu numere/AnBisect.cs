using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class AnBisect
    {
        /// <summary>
        /// Detreminati daca un an y este an bisect.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Introduceti anul pe care doriti sa il verificati daca este bisect: ");
            int y;
            y = int.Parse(Console.ReadLine());

            if ((y % 4 == 0 && y % 100 != 0)||(y % 400 == 0))
                Console.WriteLine($"anul {y} este BISECT");
            else
                Console.WriteLine($"anul {y} este NORMAL");
            Console.ReadKey();
        }
    }
}
