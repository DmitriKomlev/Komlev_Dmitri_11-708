using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
                array[i] = i;
            Console.WriteLine("enter numbers");
            do
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (array[a] != array[b])
                    break;
                for(int j = 0; j<count; j++)
                {

                }
            }
        }
    }
}
