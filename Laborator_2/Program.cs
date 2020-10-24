using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_2
{
    class Program
    {
        /// <summary>
        /// Problema 1
        /// </summary>
        //se da un vector de valori v de dimensiune n cu v[i][1si20]
        //se cere cata apa poate retine vectorul 

        //pentru o pozitie din vector vedem daca exista val mai mare in stanga (undeva) 
        //si in drapta daca exista poate ramane apa

        //incercam o metoda aleatoare
        static Random rnd = new Random();

        /// <summary>
        /// Problema 2 
        /// </summary>
        /// <param name="args"></param>
        //se da o matrice de 3X3 in care se introduc valorile(1,..,9) distincte
        //o solutie este o configuratie a matricii in care suma de pe fiecare linie este
        //egala cu suma de pe fiecare coloana
        //si suma de pe fiecare diagonala
        //afisati o solutie daca exista

        static void Apa()
        {
            int[] v = new int[] { 1, 6, 3, 1, 1, 2, 5, 1, 1, 4, 2, 1, 3, 6, 7, 1, 8, 2 };
            int n = v.Length;
            int nrapa = 0;

            for(int j =0;j<90000;j++)
            {
                int p = rnd.Next(1, n - 1);
                bool isleft = false;
                for(int i=p-1;i>=0;i--)
                    if(v[i]>v[p])
                    {
                        isleft = true;
                        break;
                    }
                bool isright = false;
                for(int i=p+1;i<n;i++)
                    if(v[i]>v[p])
                    {
                        isright = true;
                        break;
                    }
                if (isleft&&isright)
                {
                    nrapa++;
                    v[p]++;
                }
            }
            Console.Write(nrapa);
            Console.ReadKey();
        }

        static void Apa_optim()
        {
            //optimizare? 
            //concepeti un while unde "fortati" apa pe o pozitie pana nu mai incape
            int[] v = new int[] { 1, 6, 3, 1, 1, 2, 5, 1, 1, 4, 2, 1, 3, 6, 7, 1, 8, 2 };
            int n = v.Length;
            int nrapa = 0;

            int max = v[0];
            for (int i = 1; i < n; i++)
                if (max < v[i])
                    max = v[i];
            int[,] m = new int[max, n]; //matrice declarare
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < v[j]; i++)
                    m[i, j] = 1;
            }
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j > n; j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < max; i++)
            {
                int idxl = 0;
                while (m[i, idxl] == 0)
                {
                    m[i, idxl] = 2;
                    idxl++;
                }

                int idxr = n - 1;
                while (m[i, idxr] == 0)
                {
                    m[i, idxr] = 2;
                    idxr--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (m[i, j] == 0)
                        nrapa++;
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Apa: " + nrapa);
            Console.ReadKey();
        }

        static void Matrice3x3()
        {
            //aleator? daca nu exista solutie decand ca nu este sau inca nu a gasit-0 algoritmul
            int[,] m = new int[3, 3];
            int count = 0;
            bool[] v = new bool[9];
            bool ok;

            do
            {
                for (int i = 0; i < 9; i++)
                    v[i] = false;
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                    {
                        int p;
                        do
                        {
                            p = rnd.Next(9);
                        } while (v[p]);
                        v[p] = true;
                        m[i, j] = p + 1;
                    }

                int sl1 = m[0, 0] + m[0,1] + m[0,2];
                int sl2 = m[1, 0] + m[1,1] + m[1,2];
                int sl3 = m[2, 0] + m[2,1] + m[2,2];
                int sc1 = m[0, 0] + m[1,0] + m[2,0];
                int sc2 = m[0, 1] + m[1,1] + m[2,1];
                int sc3 = m[0, 2] + m[1,2] + m[2,2];
                int sd1 = m[0, 0] + m[1,1] + m[2,2];
                int sd2 = m[0, 2] + m[1,1] + m[2,0];

                ok = false;
                if (sl1 == sl2 && sl1 == sl3 && sl1 == sc1 && sl1 == sc2 && sl1 == sc3 && sl1 == sd1 && sl1 == sd2)
                    ok = true;
                count++;

            } while (!ok);

            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

        static void Matrice4x4()
        {
            //matrice de 4x4 cu valori inter 1 si 16
            int[,] m = new int[4, 4];
            int count = 0;
            bool[] v = new bool[15];
            bool ok;

            do
            {
                for (int i = 0; i < 15; i++)
                    v[i] = false;
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                    {
                        int p;
                        do
                        {
                            p = rnd.Next(15);
                        } while (v[p]);
                        v[p] = true;
                        m[i, j] = p + 1;
                    }

                int sl1 = m[0, 0] + m[0, 1] + m[0, 2] + m[0,3];
                int sl2 = m[1, 0] + m[1, 1] + m[1, 2] + m[1,3];
                int sl3 = m[2, 0] + m[2, 1] + m[2, 2] + m[2,3];
                int sl4 = m[3, 0] + m[3, 1] + m[3, 2] + m[3,3];
                int sc1 = m[0, 0] + m[1, 0] + m[2, 0] + m[3,0];
                int sc2 = m[0, 1] + m[1, 1] + m[2, 1] + m[3,1];
                int sc3 = m[0, 2] + m[1, 2] + m[2, 2] + m[3,2];
                int sc4 = m[0, 3] + m[1, 3] + m[2, 3] + m[3,3];
                int sd1 = m[0, 0] + m[1, 1] + m[2, 2] + m[3,3];
                int sd2 = m[0, 3] + m[1, 2] + m[2, 1] + m[3,1];

                ok = false;
                if (sl1 == sl2 && sl1 == sl3 && sl1 == sl4 && sl1 == sc1 && sl1 == sc2 && sl1 == sc3 && sl1 == sc4  && sl1 == sd1 && sl1 == sd2)
                    ok = true;
                count++;

            } while (!ok);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            //Apa();
            //Apa_optim();
            //Matrice3x3();

            //TODO tema cu matrice de 4X4
            Matrice4x4();

        }
    }
}
