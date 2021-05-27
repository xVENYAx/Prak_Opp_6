using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Diff(6, 5);
            int b = Mult(6, 5);
            double d = Diff(4.7, 9.2);
            double e = Mult(4.7, 9.2);
            double f = Expon(1.2, 2.0);
            
            Console.WriteLine("Введiть ваше слово: ");
            string n = Console.ReadLine();
            Console.WriteLine("Iнвертоване слово: " + Reverce(n));
            Console.WriteLine($" 6-5= {a}, 6*5= {b}, 4.7-9.2= {d}, 4.7*9.2= {e}, 1.2 * 2.0= {f}");

            Console.ReadKey();
        }
        private static double Diff(double d1, double d2)
        {
            return d1 - d2;
        }
        private static int Diff(int i1, int i2)
        {
            return i1 - i2;
        }
        private static double Mult(double d1, double d2)
        {
            return d1 * d2;
        }
        private static int Mult(int i1, int i2)
        {
            return i1 * i2;
        }
        private static double Expon(double d1, double d2)
        {
            return Math.Pow(d1, d2);
        }
        private static string Reverce(string str)
        {
            string nstr = "";

            for (int i = str.Length - 1; i >= 0; i--)

            {

                nstr += str[i];

            }

            return nstr;
        }
        


    }
}
