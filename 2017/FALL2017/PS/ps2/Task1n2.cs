using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sem2ex2
{
    class Program
    {
        //выполнил Комлев Дмитрий
        //Задача: вычислить сумму ряда (sinh(x))
        public static double[] CalculateSum(double eps, double x)
        {
            double sum = 0, elem = x;
            int step = 1;
            while (Math.Abs(elem) >= eps)
            {
                Console.WriteLine("{0}     {1}", sum, elem);
                sum +=  elem;
                step++;
                elem *= x * x / ((2 * step-2) * (2 * step - 1));  
            }
            return new double[] { sum, step - 1 };
        }
        static void Main(string[] args)
        {
            double eps, x;
            x = double.Parse(Console.ReadLine());
            eps = double.Parse(Console.ReadLine());
            double[] answer = CalculateSum(eps, x);
            Console.WriteLine("значение {0} достигается на {1} шаге", answer[0],answer[1]);
            Console.ReadLine();
        }
    }
}
