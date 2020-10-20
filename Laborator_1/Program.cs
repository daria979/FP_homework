using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        //[2 12]
        //generam aleator numerele
        static Random rnd = new Random();
        //este o variabila aleatoare cu distributie uniforma
        static void Main(string[] args)
        {


            int a, b, c, d, e;
            int cr = 1000;

            do
            {



                a = rnd.Next(2, 13);
                //rnd.Next(minvalue, maxvalue) - [minvalue, maxvalue)
                b = rnd.Next(2, 13);
                c = rnd.Next(2, 13);
                d = rnd.Next(2, 13);
                e = rnd.Next(2, 13);

                cr--;

                Console.WriteLine("({0} {1} {2} {3} {4})", a, b, c, d, e);

                //1 vector de frecventa
                // vreau sa construiesc un vector de dim 13 {ignoram (0,1),[2, ... 12], 13(null)}
                int[] vn = new int[13];
                //c# va asigura ca val vectorului sunt default la initializare (0)
                for (int i = 0; i < 13; i++)
                    vn[i] = 0;

                vn[a]++;
                vn[b]++;
                vn[c]++;
                vn[d]++;
                vn[e]++;


                //for (int i = 0; i < 13; i++)
                //    Console.Write(vn[i] + " ");
                //(2,2,1   000)
                //(2,1,1,1 000)
                //(3,2     000)

                //cinci id    (5,0,0,0,0 ... ) max 5 nrp 0
                //patru id    (4,1,0,0,0 ... ) max 4 nrp 0
                //trei id     (3,1,1,0,0 ... ) max 3 nrp 0
                //trei id + 2 (3,2,0,0,0 ... ) max 3 nrp 1
                //2 + 2       (2,2,1,0,0 ... ) max 2 nrp 2
                //2           (2,1,1,1,0 ... ) max 2 nrp 1
                //1           (1,1,1,1,1 ... ) max 1 nrp 0


                //(1,1,1,1,1) => 10
                //(1,1,1,1,0) => 6
                //(1,1,1,2,2) => 4
                //(1,1,1,0,2) => 3
                //(1,1,2,2,0) => 2
                //(1,1,2,3,0) => 1
                //(1,3,4,5,0) => 0




                int nrid = 0;
                if (a == b) nrid++;
                if (a == c) nrid++;
                if (a == d) nrid++;
                if (a == e) nrid++;
                if (b == c) nrid++;
                if (b == d) nrid++;
                if (b == e) nrid++;
                if (c == d) nrid++;
                if (c == e) nrid++;
                if (d == e) nrid++;

                switch (nrid)
                {
                    case 10: Console.Write("Cinci id"); break;
                }

                int max = 0;
                int nrp = 0;
                for (int i = 2; i < 13; i++)
                {
                    if (vn[i] > max)
                        max = vn[i];
                    if (vn[i] == 2)
                        nrp++;
                }

                if (max == 5)
                {
                    Console.Write("cinci identice");
                    cr += 400;
                }
                if (max == 4)
                {
                    Console.Write("patru identice");
                    cr += 40;
                }
                if (max == 3 && nrp == 1)
                {
                    Console.Write("3 + 2");
                    cr += 20;
                }
                if (max == 3 && nrp == 1)
                {
                    Console.Write("3");
                    cr += 3;
                }
                if (max == 2 && nrp == 2)
                {
                    Console.Write("2 + 2");
                    cr += 1;
                }
                if (max == 2 && nrp == 1)
                {
                    Console.Write("2");
                    cr += 1;
                }
                if (max == 1)
                    Console.Write("nimic");
                Console.WriteLine();
                Console.WriteLine("cr =" + cr);

            }
            while (cr > 0);
            Console.ReadKey();






            //ALGORITMI DE SORTARE
            static Random rnd = new Random();
            static void Main(string[] args)
            {

                int n = 10000;

                int[] v = new int[n];
                v[0] = 0;
                for (int i = 1; i < n; i++)
                    v[i] = v[i - 1] + rnd.Next(2);

                for (int i = 0; i < n; i++)
                    Console.Write("{0} ", v[i]);

                int aux;
                /*
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                    {
                        if (v[i] > v[j])
                        {
                            aux = v[i];
                            v[i] = v[j];
                            v[j] = aux;
                        }
                    }
                */

                /*bublle sort imbunatatit*/

                int k = 0;
                bool OK = false;
                do
                {
                    OK = true;
                    for (int i = 0; i < n - 1 - k; i++)
                        if (v[i] > v[i + 1])
                        {
                            aux = v[i];
                            v[i] = v[i + 1];
                            v[i + 1] = aux;
                            OK = false;
                        }
                    k++;
                } while (!OK);


                /*selection sort (foram de baza)*/
                /*
                for (int j = 0; j < n - 1; j++)
                {
                    int min = v[j];
                    int poz = j;
                    for (int i = j + 1; i < n; i++)
                    {
                        if (min > v[i])
                        {
                            min = v[i];
                            poz = i;
                        }
                    }
                    aux = v[poz];
                    v[poz] = v[j];
                    v[j] = aux;

                }*/
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                    Console.Write("{0} ", v[i]);

                //tema de cercertare/ reamintere (insertion sort)
                //[...]
                //consideram ca avem 4 algoritmi de sortare


                //for ( for (n - n )) = n^2 (indiferent ca tai cateva elemente din n tot asimptotic tot n^2 operatii sunt)
                //selection sort (Exact aceeasi problema) (tot n^2 operatii sunt)
                //buble sort castiga doar in caz particular, cand vectorul este sortat (n) dara in general merge tot n^2

                Console.ReadKey();
            }

        }
    }
}
