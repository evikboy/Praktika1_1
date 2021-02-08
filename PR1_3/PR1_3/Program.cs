using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, xmin, xmax, delt_x, a, k, y;
            Console.Write("Введите xmin = ");
            xmin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите xmax = ");
            xmax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг = ");
            delt_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k = ");
            k = Convert.ToDouble(Console.ReadLine());

            double A, B, C;

            for (x = xmin; x <= xmax; x += delt_x)
            {
                A = Math.Cos(a * x);
                B = a * x;
                C = Math.Log(B);
                if (A >= 0 && B > 0 && C != 0)
                {
                    y = Math.Pow(A, 1.0 / 3.0) + k * A / C;
                    Console.WriteLine("x = {0}\t\t->\t\ty = {1} ", x, y);
                }
              
            }
        }
    }
}
