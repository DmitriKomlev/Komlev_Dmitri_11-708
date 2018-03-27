using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1Ex5
{
    class Program
    {
        //Посчитать, сколько совершенных чисел от 0 до 1000000. Число n - совершенное, если сумма его делителей равна 2n.
        static void Main(string[] args)
        {
            int p=1,k=0,k1=0;
            double num,tempNum;
            num = (Math.Pow(2, p-1))*(Math.Pow(2,p)-1);
            while(num<=1000000)
            {
                tempNum = Math.Pow(2, p) - 1;
                k = 0;
                for (int i = 1; i<=tempNum/2;i++)
                {
                    if (tempNum % i == 0) k++;
                    if (k > 1) break;
                }
		// не количество, а сумма же
                if (k + 1 == 2) k1++;
                p++;
                num = (Math.Pow(2, p - 1)) * (Math.Pow(2, p) - 1);
            }
            Console.WriteLine(k1);
            Console.ReadLine();
        }
    }
}
