using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Secv_Bitonica_rotita
    {
        /// <summary>
        /// O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi
        /// transformata intr-o secventa bitonica prin rotiri succesive(rotire =
        /// primul element devine ultimul). Se da o secventa de n numere.Se cere sa se determine daca este o
        /// secventa bitonica rotita.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere de la tastatura: ");
            int x = int.Parse(Console.ReadLine());
            bool ok = false; bool ok2 = false;
            int attempts = 0; // doar o singura data se poate intampla asta!
            
            for (int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if(x<=y)
                {
                    if (x <= y)
                        ok = true;
                    else
                    {
                        attempts++;
                        if (attempts == 1 && x >= y)
                            ok2 = true;
                        
                        else
                        {
                            ok = false;
                            break;
                               
                        }

                    }
                    x = y;
                }

            }
           
            if (ok == true && ok2 == true )
                Console.WriteLine("Secventa este bitonica ROTITA!");
            else
                Console.WriteLine("Secventa NU este bitonica rotita!");
        }
    }
}
