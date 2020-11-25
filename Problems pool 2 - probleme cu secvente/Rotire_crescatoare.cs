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

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

               
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
