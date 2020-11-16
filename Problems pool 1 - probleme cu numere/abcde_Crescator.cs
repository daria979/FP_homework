using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class abcde_Crescator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti cinci numere diferite intreg de la tastatura: ");
            int a, b, c, d, e;

            try
            {
                Console.Write("a: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                    throw new Exception("Nu ati introdus un numar !");
                Console.Write("b: ");
                if (!int.TryParse(Console.ReadLine(), out b))
                    throw new Exception("Nu ati introdus un numar !");
                Console.Write("c: ");
                if (!int.TryParse(Console.ReadLine(), out c))
                    throw new Exception("Nu ati introdus un numar !");
                Console.Write("d: ");
                if (!int.TryParse(Console.ReadLine(), out d))
                    throw new Exception("Nu ati introdus un numar !");
                Console.Write("e: ");
                if (!int.TryParse(Console.ReadLine(), out e))
                    throw new Exception("Nu ati introdus un numar !");
                if (a == b && b == c && c==d && d==e)
                    throw new Exception("Nu ati introdus 3 numere distincte!");

                if(a<b)
                {
                    int aux = a;
                    a = b;
                    b = aux;
                }
                if(a<c)
                {
                    int aux = a;
                    a = c;
                    c = aux;
                }
                if(a<d)
                {
                    int aux = a;
                    a = d;
                    d = aux;
                }
                if(a<e)
                {
                    int aux = a;
                    a = e;
                    e = aux;
                }
                if(b<c)
                {
                    int aux = b;
                    b = c;
                    c = aux;
                }
                if(b<d)
                {
                    int aux = b;
                    b = d;
                    d = aux;
                }
                if(b<e)
                {
                    int aux = b;
                    b = e;
                    e = aux;
                }
                if(c<d)
                {
                    int aux = c;
                    c = d;
                    d = aux;
                }
                if(c<e)
                {
                    int aux = c;
                    c = e;
                    e = aux;
                }
                if(d<e)
                {
                    int aux = d;
                    d = e;
                    e = aux;
                }

                Console.WriteLine($"Cele 5 numere ordonare crescator sunt: {e} {d} {c} {b} {a}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
