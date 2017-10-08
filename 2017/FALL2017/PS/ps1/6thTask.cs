using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1Ex6_1
{
    class Program
    {
        //По заданному числу (от 1 до 10^12) найти его самый большой простой делитель
        public static bool IsNumSimple(long num)
        {
            //проверяем, является ли число простым
            int k = 0;
            for (long i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) k++;
                if (k > 1) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            long num = int.Parse(Console.ReadLine());
            // 1 не имеет простых делителей, т.к. сама 1 не простое число
            if (num == 1) Console.WriteLine("This number doesn`t have any simple denominator");
            else
            {
                //если число простое, то его  наибольший простой делитель - оно само
                if (IsNumSimple(num) == true) Console.WriteLine(num);
                else for (long i=num; i>=1;i--)
                    {
                        if ((num%i==0)&&(IsNumSimple(i)))
                        {
                            Console.WriteLine("Greatest denominator of your number : {0}",i);
                            break;
                        }
                    }
                
            }
            Console.ReadLine();
        }
    }
}
