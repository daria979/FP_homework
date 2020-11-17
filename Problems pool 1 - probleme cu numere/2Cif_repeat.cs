using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class _2Cif_repeat
    {
        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. 
        /// De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static bool frecventa(int n)
        {
            // ne vom folosi de numarul de aparitii a fiecarei cifra din numarul n
            int[] v = new int[10];
            for(int i=0;i<10;i++)
            {
                v[i] = 0; //prima data initializam
            }
            while(n>0)
            {
                v[n % 10]++; //incrementam daca exista acea cifra
                n = n / 10;
            }
            int nr = 0;
            for(int i=0;i<10;i++)
            {
                if (v[i] > 0)
                    nr++;
            }
            if (nr == 2)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg de la tastatura: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                if(frecventa(n))
                    Console.WriteLine($"Numar {n} e format doar cu 2 cifre care se pot repeta.");
                else
                    Console.WriteLine($"Numar {n} NU e format doar cu 2 cifre care se pot repeta.");


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
