using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Cautarea_Binara
    {
        /// <summary>
        /// Cautare binara. 
        /// Se da un vector cu n elemente sortat in ordine crescatoare.
        /// Se cere sa se determine pozitia unui element dat k.
        /// Daca elementul nu se gaseste in vector rezultatul va fi -1.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static int n, x, m;
        static int[] v;
        static void Main(string[] args)
        {
            n = 0;
            x = 0;
            m = 0;

            Console.Write("n= "); 
            n = int.Parse(Console.ReadLine());

            v = new int[n]; 

            Console.Write("x= "); 
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elemente in ordine crescatoare: ");

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"Elementul a fost gasit pe pozitia {cautare(0, n - 1)}!" );
            Console.ReadKey();
        }

        static int cautare(int s, int d)
        {
            if (s > d)
                return -1;

            m = (s + d) / 2;
            if (x == v[m])
                return m;
            if (x < v[m])
                return cautare(s, m - 1);
            else
                return cautare(m + 1, d);
        }

        //Algoritmul de căutare binară este un algoritm de căutare folosit pentru a găsi un
        //element într-o listă ordonată (tablou unidimensional/vector). 
        //Algoritmul funcționează pe baza tehnicii divide et impera. 
        //Valoarea căutată este comparată cu cea a elementului din mijlocul listei. 
        //Dacă e egală cu cea a acelui element, algoritmul se termină. 
        //Dacă e mai mare decât acea valoare, algoritmul se reia, de la mijlocul listei până la sfârșit, 
        //iar dacă e mai mică, algoritmul se reia pentru elementele de la începutul listei până la mijloc. 
        //Întrucât la fiecare pas cardinalul mulțimii de elemente în care se efectuează căutarea 
        //se înjumătățește, algoritmul are complexitate logaritmică.
    }
}
