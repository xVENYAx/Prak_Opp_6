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
            int a = Diff(99, 25);
            int b = Mult(6, 10);
            double d = Diff(2.7, 10.2);
            double e = Mult(4.7, 6.6);
            double f = Expon(1.2, 3.3);
            
            Console.WriteLine("Введiть ваше слово: ");
            string n = Console.ReadLine();
            Console.WriteLine("Iнвертоване слово: " + Reverce(n));
            Console.WriteLine($" 99-25= {a}, 6*10= {b}, 2.7-10.2= {d}, 4.7*6.6= {e}, 1.2 * 3.3= {f}");

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
