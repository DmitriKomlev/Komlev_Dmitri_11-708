using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace linq1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Console.WriteLine("Enter each number with \"enrer\"(\"q\" - stop)");
            while (true)
            {
                string num = Console.ReadLine();
                if (num == "q")
                    break;
                list.Add(int.Parse(num));
            }
            IEnumerable<int> listMod2 = list.Where(x => x % 2 == 0);
            IEnumerable<int> listSkipK = list.Skip(k);
            IEnumerable<int> unionLists = listMod2.Union(listSkipK);
            IEnumerable<int> finalList = unionLists.Except(listSkipK);
            int[] arrayMod2 = listMod2.ToArray();
            for (int i = 0; i < arrayMod2.Count(); i++)
                Console.Write(arrayMod2[i] + " ");
            Console.WriteLine();
            int[] arraySkipK = listSkipK.ToArray();
            for (int i = 0; i < arraySkipK.Count(); i++)
                Console.Write(arraySkipK[i] + " ");
            Console.WriteLine();
            int[] array = finalList.ToArray();
            for (int i = 0; i < array.Count(); i++)
                Console.Write(array[i] + " ");
            Console.ReadLine();




        }
    }
}
