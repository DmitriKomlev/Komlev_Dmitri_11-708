using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2ex4
{
    class Program
    {
        //выполнил Комлев Дмитрий
        //Задача: вычислить сумму ряда (pi)
        public static double[] CalculatePi(double eps)
        {
            double sum = 1, elem = 1,elemPrev;
            int step = 1;
            sbyte sign = 1;
            do
            {
                sign *= -1;
                elemPrev = elem;
                elem *= (2 * (double)step -1) / (3 * (2 *(double) step + 1));
                step++;
                sum += sign * elem;
            }
            while (Math.Abs(elem - elemPrev) > eps);
            return new double[] { sum, step - 1 };
        }
        static void Main(string[] args)
        {
            double eps = double.Parse(Console.ReadLine());
            double[] answer = CalculatePi(eps);
            Console.WriteLine("значение {0} достигается на {1} шаге", answer[0], answer[1]);
            Console.ReadLine();
        }
    }
}
