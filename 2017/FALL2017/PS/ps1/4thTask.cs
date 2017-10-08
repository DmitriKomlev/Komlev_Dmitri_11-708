using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1Ex4
{
    class Program
    {
        //На вход подаётся последовательность из n целых чисел (по модулю <=10^9). Определить является ли последовательность знакопеременной (чередуются знаки элементов)
        static void Main(string[] args)
        {
            int nextNum, pastNum=0,temp=0;
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i<=k; i++)
            {
                if (i == 1) pastNum = int.Parse(Console.ReadLine());
                else
                {
                    nextNum = int.Parse(Console.ReadLine());
                    if (pastNum / nextNum < 0) temp++;
                    Console.WriteLine("temp={0}", temp);
                    pastNum = nextNum;
                }
            }
            if (temp == k - 1) Console.WriteLine("последовательность знакопеременная");
            else Console.WriteLine("последовательность не знакопеременная");
            Console.ReadLine();
        }
    }
}
