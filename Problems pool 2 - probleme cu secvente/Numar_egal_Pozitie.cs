using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Numar_egal_Pozitie
    {
        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa? 
        /// Se considera ca primul element din secventa este pe pozitia 0.
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

                int nr_egalitati = 0;
                Console.WriteLine("Secventa data este: ");
                for (int i=0;i<n;i++)
                {
                    int x = rnd.Next(101);
                    Console.Write($"{x} ");
                    if (i == x)
                        nr_egalitati++;
                }
                Console.WriteLine();
                Console.WriteLine($"{nr_egalitati} numere sunt egale cu pozitia lor in secventa data.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
