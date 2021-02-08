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
            double x, xmin, xmax, delt_x, c, y;
            Console.Write("Введите xmin = ");
            xmin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите xmax = ");
            xmax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг = ");
            delt_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());

            double A, B;
            

            for (x = xmin; x <= xmax; x += delt_x)
            {
                A = c * c * x * x + 2.0;
                B = x * x + 1.0;
                if (A >= 0 && B > 0)
                {
                    y = Math.Pow(A, 1.0 / 3.0) + Math.Log(B) / (2.0 * Math.PI);
                    Console.WriteLine("x = {0}\t\t->\t\ty = {1} ", x, y);
                }
            }
        }
    }
}
