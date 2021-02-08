using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Program
    {

        static void Main(string[] args)
        {
            string s;
            double x, a, c;
            double y;
            double A, B;

            Console.Write("Введите x = ");
            s = Console.ReadLine();
            x = Convert.ToDouble(s);

            Console.Write("Введите a = ");
            s = Console.ReadLine();
            a = Convert.ToDouble(s);

            Console.Write("Введите c = ");
            s = Console.ReadLine();
            c = Convert.ToDouble(s);

            A = c * x - a;
            B = 2.0 * Math.Sin(Math.PI / 3.0 + x);

            if (A >= 0 && x > 0 && B != 0)
            {
                y = Math.Pow(A, 1.0 / 3.0) + Math.Log(x) / B;
                Console.WriteLine("\nx = {0}, a = {1}, c = {2}", x,a,c);
                Console.WriteLine("y = {0} ", y);
            }
        }
    }
}

