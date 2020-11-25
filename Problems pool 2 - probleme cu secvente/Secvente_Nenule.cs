using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Secvente_Nenule
    {
        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere? 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
        /// </summary>
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                int nr = 1;
                double x;


                Console.WriteLine("Secventa este: ");
                for (int i = 0; i < n; i++)
                {
                    x = rnd.Next(11);
                    
                    if (x != 0)
                        Console.Write($"{x} ");
                    else
                    {
                        Console.WriteLine();
                        nr++;
                    }
                        
                }
                Console.WriteLine();
                Console.WriteLine($"In secventa data sunt {nr} secvente cu elemente nenule.");
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
