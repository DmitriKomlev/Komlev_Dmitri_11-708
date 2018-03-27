using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2ex5
{
    class Program
    {
        //выполнил Комлев Дмитрий
        //задача: 5 способами вычислить интеграл
        static double Function(double x)
        {
            return (Math.Sin(x*x));
        }
        //ф-ла левых прямоугольников
        static double CalculateByLeftTriangles(double n) 
        {
            double sum = 0;
            for(double i=0; i<2; i += 1.0 / n )
                sum += 1.0 / n * Function(i);
            return sum;
        }
        // ф-ла правых прямоугольников
        static double CalculateByRightTriangles(double n) 
        {
            double sum = 0;
            for(double i= 1.0 / n;i<=2; i += 1.0 / n)
                sum += 1.0 / n * Function(i);
            return sum;
        }
        // ф-ла трапеции
        static double CalculateByTrapeze(double n) 
        {
            double sum = 0;
            for(double i = 0;i<2; i += 1.0 / n)
                sum += 1.0 / n * ((Function(i) + Function(i + 1.0 / n)) / 2);
            return sum;
        }
        //ф-ла Симпсона
        static double CalculateBySimpson(double n)  
        {
            int b = 2;
            int a = 0;
            double step = (double)Math.Abs(b - a) / n;
            double sum = 0.0;
            double currentValue = 0.0;
            currentValue = a + step;
            while (currentValue < b)
            {
                sum += 4 *Function(currentValue);
                currentValue+= step;
                sum += 2 * Function(currentValue);
                currentValue = currentValue + step;
            }
            return (step / 3 * (sum + Function(a) - Function(b)));
        }
        // ф-ла Монте-Карло
        static double CalculateByMonteKarlo(double n)
        {
            double b = 2;
            int numOfDown = 0;
            Random random = new Random();
            for (int i = 0; i <=n; i++)
            {
				// ---check--- а почему в b? есть же естественное ограничение sin(x^2) < 1
                double maxFunction = Function(b);
                //рандом по Y
                double randNumY = random.NextDouble() * maxFunction;
                //рандом по X
                double randNumX = random.NextDouble() * b;
                if (randNumY <= Function(randNumX))
                    numOfDown++;
            }
            return numOfDown/ n;
            
        }
		
		// ---check--- почему не сделали границы интервала параметрами?
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число отрезков/итераций n.");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("формула левых прямоугольников: {0}",CalculateByLeftTriangles(n));
            Console.WriteLine("формула правых прямоугольников: {0}", CalculateByRightTriangles(n));
            Console.WriteLine("формула трапеций: {0}", CalculateByTrapeze(n));
            Console.WriteLine("формула Симпсона: {0}", CalculateBySimpson(n));
            Console.WriteLine("формула Монте-Карло: {0}", CalculateByMonteKarlo(n));
            Console.ReadLine();
        }
    }
}
