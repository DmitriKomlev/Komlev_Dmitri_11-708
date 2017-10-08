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
            int numTicket=int.Parse(Console.ReadLine());
            int firstPart = numTicket%10 + (numTicket/100)%10 + (numTicket/10000)%10; //присваиваем переменной FisrtPart сумму 1,3,5 цифр номера билета
            int secondPart = (numTicket/10)%10 + (numTicket/1000)%10 + numTicket/100000;//присваиваем переменной SecondPart сумму 2,4,6 цифр номера билета
            if (firstPart==secondPart) //Сравниваем полученнные суммы
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
