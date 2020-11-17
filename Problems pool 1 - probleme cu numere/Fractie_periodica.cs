using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Fractie_periodica
    {
        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). 
        /// Exemplu: 13/30 = 0.4(3).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numare intregi de la tastatura: ");
            float n,m;
            float rezultat=0;
            

            try
            {
                Console.Write("n: ");
                if (!float.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write("m: ");
                if (!float.TryParse(Console.ReadLine(), out m))
                    throw new Exception("Nu ati introdus un numar !");
                if(m==0)
                    throw new Exception("Nu se poate realiza impartirea cu 0 !");

                rezultat = n / m;
                
                int impartire;
                string numar = Convert.ToString(rezultat);
               
                int decpart;
                char[] dot = { '.' };
                string[] numere_intregi = numar.Split(dot, StringSplitOptions.RemoveEmptyEntries);

                int intpart = int.Parse(numere_intregi[0]);
                decpart = int.Parse(numere_intregi[1]);
                impartire = decpart;
                Console.WriteLine($"Fractia zecimala obtinuta este: {decpart}");
                
                //TODO
                //DE TERMINAT PROBLEMA!!!!!!!!!!!!!!!!!!!!

              
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
