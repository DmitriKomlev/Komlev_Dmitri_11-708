using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1Ex3
{
    class Program
    {
        //Найти сумму цифр в k-ичной системе счисления (k от 2 до 10) десятичного натурального числа n (n<=10^9)
        static long TranslationFrom10(long number, int degree)
        {
            long sum=0;
            while (number != 0)
            {
                sum += (number % degree);
                number = number / degree;
                if (number == 0) sum += (number / degree);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int degree = int.Parse(Console.ReadLine());
            
           

            Console.WriteLine(TranslationFrom10(number,degree));
            Console.ReadLine();
            
        }
    }
}
