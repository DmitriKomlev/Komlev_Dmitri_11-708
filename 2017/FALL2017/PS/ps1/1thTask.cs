using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверить, является ли билет счастливым по-питерски (abcdef=>a+c+e=b+d+f)
            Console.Write("Enter your ticket number: ");
            string NumTicket=Console.ReadLine();
            int FirstPart = NumTicket[0] + NumTicket[2] + NumTicket[4]; //присваиваем переменной FisrtPart сумму 1,3,5 цифр номера билета
            int SecondPart = NumTicket[1] + NumTicket[3] + NumTicket[5];//присваиваем переменной SecondPart сумму 2,4,6 цифр номера билета
            if (FirstPart==SecondPart) //Сравниваем полученнные суммы
            {
                Console.WriteLine("Congratulations! You are got a lucky ticket!");
            }
            else
            {
                Console.WriteLine("Unfortunately, your ticket is not happy");
            }
            Console.ReadLine();
        }
    }
}
