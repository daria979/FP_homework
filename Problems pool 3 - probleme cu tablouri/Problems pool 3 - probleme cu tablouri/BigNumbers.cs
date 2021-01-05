using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class BigNumbers
    {
        static string findSum(string str1, string str2)
        {
            //str2 trebuie sa fie mai mare
            if (str1.Length > str2.Length)
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }

            // un string gol pt rezultat 
            string str = "";

            int n1 = str1.Length, n2 = str2.Length;

            // inversarea string-urilor
            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            str1 = new string(ch);
            char[] ch1 = str2.ToCharArray();
            Array.Reverse(ch1);
            str2 = new string(ch1);

            int carry = 0;
            for (int i = 0; i < n1; i++)
            {

                int sum = ((int)(str1[i] - '0') +
                        (int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');

                // calculeaza "carry-ul" pentru pasul urmator  
                carry = sum / 10;
            }

            // se adauga cifrele ramase pentru numarul mai mare 
            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // se adauga carry-ul 
            if (carry > 0)
                str += (char)(carry + '0');

            // se inverseaza string-ul in care este stocat rezultatul
            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);

            return str;
        }


        static bool isSmaller(string str1, string str2)
        {

            int n1 = str1.Length, n2 = str2.Length;

            if (n1 < n2)
                return true;
            if (n2 < n1)
                return false;

            for (int i = 0; i < n1; i++)
            {
                if (str1[i] < str2[i])
                    return true;
                else if (str1[i] > str2[i])
                    return false;
            }
            return false;
        }

        //DIFERENTA
        static string findDiff(string str1, string str2)
        {
            //str2 este mai mare
            if (isSmaller(str1, str2))
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }


            String str = "";

            int n1 = str1.Length, n2 = str2.Length;
            int diff = n1 - n2;

            int carry = 0;


            for (int i = n2 - 1; i >= 0; i--)
            {
                int sub = (((int)str1[i + diff] - (int)'0')
                           - ((int)str2[i] - (int)'0') - carry);
                if (sub < 0)
                {
                    sub = sub + 10;
                    carry = 1;
                }
                else
                    carry = 0;

                str += sub.ToString();
            }

            // sse scad cifrele ramase ale numarului mai mare
            for (int i = n1 - n2 - 1; i >= 0; i--)
            {
                if (str1[i] == '0' && carry > 0)
                {
                    str += "9";
                    continue;
                }
                int sub = (((int)str1[i] - (int)'0') - carry);
                if (i > 0 || sub > 0)
                    str += sub.ToString();
                carry = 0;
            }


            char[] aa = str.ToCharArray();
            Array.Reverse(aa);
            return new string(aa);
        }

        //Inumultirea
        static string multiply(string num1, string num2)
        {
            int len1 = num1.Length;
            int len2 = num2.Length;
            if (len1 == 0 || len2 == 0)
                return "0";

            //vom tine minte intr un vector rezultatul, dar in ordinea inversa 
            int[] result = new int[len1 + len2];


            int i_n1 = 0;
            int i_n2 = 0;
            int i;

            // de la dreapta spre stanga in str1
            for (i = len1 - 1; i >= 0; i--)
            {
                int carry = 0;
                int n1 = num1[i] - '0';

                //pentru a muta pozitia cu 1 spre stanga 
                i_n2 = 0;

                // de la dreapta spre stanga in str2             
                for (int j = len2 - 1; j >= 0; j--)
                {
                    // numarul curent de cifre al lui nr 2  
                    int n2 = num2[j] - '0';

                    int sum = n1 * n2 + result[i_n1 + i_n2] + carry;

                    carry = sum / 10;


                    result[i_n1 + i_n2] = sum % 10;

                    i_n2++;
                }


                if (carry > 0)
                    result[i_n1 + i_n2] += carry;


                i_n1++;
            }


            i = result.Length - 1;
            while (i >= 0 && result[i] == 0)
                i--;


            if (i == -1)
                return "0";


            String s = "";

            while (i >= 0)
                s += (result[i--]);

            return s;
        }
        static void Main(string[] args)
        {
            string nr1 = "4593744";
            string nr2 = "346";

            Console.Write($"SUMA: {findSum(nr1, nr2)}");

            Console.WriteLine();
            Console.Write($"DIFERENTA: {findDiff(nr1, nr2)}");

            Console.WriteLine();
            Console.Write($"PRODUSUL: {multiply(nr1, nr2)}");

            Console.WriteLine();

        }
    }
}
