using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sem2ex3
{
    class Program
    {
        //выполнил Комлев Дмитрий
        //Задача: вычислить сумму ряда (1/(sqrt(1+x)))
        public static double[] CalculateSum(double eps, double x)
        {
            double sum = 1, elem = 1;
            int step = 1;
            sbyte sign = 1;
            while (Math.Abs(elem) >= eps)
            {
                sign *= -1;
                elem *= x * (2 *step-1) / 2 / step;
                step++;
                sum += sign * elem;
            }
            return new double[] { sum, step-1 };
        }
        static void Main(string[] args)
        {
            double eps, x;
            Console.WriteLine("enter |x|<1");
            x = double.Parse(Console.ReadLine());
            eps = double.Parse(Console.ReadLine());
            double[] answer = CalculateSum(eps, x);
            Console.WriteLine("значение {0} достигается на {1} шаге", answer[0], answer[1] );
            Console.ReadLine();
        }
    }
}
