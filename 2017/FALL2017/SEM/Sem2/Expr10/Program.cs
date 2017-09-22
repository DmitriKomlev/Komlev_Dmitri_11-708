using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr9
{
    class Program
    {
        static int Sum(int firstNum, int lastNum, int denomin)
        {// количество чисел кратных x на заданном отрезке при помощи арифметич. прогрессии
            firstNum = (firstNum % denomin == 0 ? firstNum : firstNum + denomin - firstNum % denomin);//ищем минимальное кратное заданному число на заданном отрезке
            lastNum--;
            lastNum = (lastNum % denomin == 0 ? lastNum : lastNum - lastNum % denomin);//ищем максимальное кратное заданному число на заданном отрезке
            int numCount = lastNum / denomin - firstNum / denomin + 1;// количество членов
            return (lastNum + firstNum) * numCount / 2;
        }
        static void Main(string[] args)
        {
            int res = Sum(1, 1000, 3) + Sum(1, 1000, 5) - Sum(1, 1000, 15);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
