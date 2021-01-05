using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Polinom_x_
    {
        /// <summary>
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un
        /// vector.Cel mai putin semnificativ coeficient este pe pozitia zero in vector.Se cere valoarea
        /// polinomului intr-un punct x.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static Random rnd = new Random();

        static void Polinom(int n, int x)
        {
            int[] coeficient = new int[n];
            for (int i = 0; i < n; i++)
            {
                int cf = rnd.Next(-10, +11); //coeficientii pot lua valori random intre -10 si +10
                coeficient[i] = cf;
            }
            Console.WriteLine("Polinomul este: ");
            int grad = n;

            //adaugam intr-o lista gradele, in cazul in care unii sunt 0 pt a se ignora la calcul
            List<int> grade = new List<int>(); 
            for (int i = 0; i < n; i++)
            {
                if (coeficient[i] != 0)
                {
                    if (Math.Sign(coeficient[i]) < 0)
                    {
                        Console.Write($" {Math.Sign(coeficient[i]) * Math.Abs(coeficient[i])}X^{grad}");
                        grade.Add(grad);
                    }
                        
                    else
                        if (i != 0)
                        {
                            Console.Write($" +{Math.Sign(coeficient[i]) * Math.Abs(coeficient[i])}X^{grad}");
                            grade.Add(grad);
                        }
                            
                }
                else
                    continue;
                grad--;

            }
            Console.WriteLine();
            Polinom_calculate(x, coeficient,grade);
        }

        static int Polinom_calculate(int x, int[]coeficient,List<int>grade)
        {
            int Value = 0;
            int i = 0;
            foreach(int elemList in grade)
            {
                Value = Value + coeficient[i] * (int)Math.Pow(x, elemList);
                i++;
            }
            Console.Write($"Valoarea polinomului in punctul {x} este: {Value}");
            Console.WriteLine();
            return Value;
        }
        static void Main(string[] args)
        {
            int n,x;
            Console.WriteLine("Introduceti gradul maxim al polinomului: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti punctul in care sa se determine valoarea polinomului: ");
            x = int.Parse(Console.ReadLine());

            Polinom(n,x); 
        }
    }
}
