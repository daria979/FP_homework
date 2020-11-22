using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class SsiP_1_la_n
    {
        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            double n;

            try
            {
                Console.Write("n: ");
                if (!double.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                double S = 0;
                double P = 1;

                for(double i=1;i<=n;i++)
                {
                    S = S + i;
                    P = P * i;
                }

                Console.WriteLine($"Suma numerelor de la 1 la {n} este {S}");
                Console.WriteLine($"Produsul numerelor de la 1 la {n} este {P}");

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
