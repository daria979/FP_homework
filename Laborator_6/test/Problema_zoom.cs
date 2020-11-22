using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Problema_zoom
    {
            static void Main(string[] args)
            {
                int n, m, i, j;
                int[,] elm = new int[100, 100];
                int[,] matr = new int[100, 100];
                int cont1 = 0, cont2 = 0;
                //cont 1  ---> linii
                //cont 2  ---> coloane

                Random rnd = new Random();

                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());

                //atribuire
                for (i = 0; i < n; i++)
                    for (j = 0; j < m; j++)
                        elm[i, j] = rnd.Next(1, 9);

                //afisare
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                        Console.Write($"{elm[i, j]} ");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Matrice noua etapa 1");


                //parcurgere matrice veche + creere matrice noua
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        matr[cont1, cont2] = elm[i, j];
                        cont2 += 2;
                    }
                    cont1 += 2;
                    cont2 = 0;
                }

                //afisare matrice etapa 1
                for (i = 0; i < 2 * n - 1; i++)
                {
                    for (j = 0; j < 2 * n - 1; j++)
                        Console.Write($"{matr[i, j]} ");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Matrice noua etapa 2");



                cont1 = 1;
                cont2 = 1;

                //parcure + medie(linii si coloane)
                for (i = 0; i < 2 * n - 1; i += 2)
                {
                    for (j = 0; j < 2 * n - 3; j += 2)
                    {
                        matr[i, cont2] = (int)((matr[i, j] + matr[i, j + 2]) / 2);
                        cont2 += 2;
                    }
                    cont2 = 1;
                }

                //afisare matrice etapa 2
                for (i = 0; i < 2 * n - 1; i++)
                {
                    for (j = 0; j < 2 * n - 1; j++)
                        Console.Write($"{matr[i, j]} ");
                    Console.WriteLine();
                    Console.WriteLine();
                }


                Console.WriteLine();
                Console.WriteLine("Afisare matrice finala");

                cont1 = 1;

                //finisare
                for (i = 1; i < 2 * n - 2; i += 2)
                {
                    for (j = 0; j < 2 * n - 1; j++)
                    {
                        matr[i, j] = (int)((matr[i - 1, j] + matr[i + 1, j]) / 2);
                        //cont1 += 1;
                    }
                }


                //afisare finish
                for (i = 0; i < 2 * n - 1; i++)
                {
                    for (j = 0; j < 2 * n - 1; j++)
                        Console.Write($"{matr[i, j]} ");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }


