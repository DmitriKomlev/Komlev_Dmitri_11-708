using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace sortCoctail
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader data = new StreamReader(@"randmass.txt");

            for (int i = 100; i < 10000; i += 50)
            {
                string str = data.ReadLine();
                string[] dataString = new string[i + 1];

                dataString = str.Split(' ');

                int[] data = new int[dataString.Count()];

                for (int j = 0; j < dataString.Count(); j++)
                    if (dataString[j] != "")
                        data[j] = int.Parse(dataString[j]);

                data = BucketSort( data);
                for (int j = 0; j < dataString.Count(); j++)
                    sortMass.Write("{0} ", data[j]);
                sortMass.WriteLine();

            }
            data.Close();
        }

		static int[] CoctailSort(int[] array)
        {
			//левая граница
            int left = 0;
			//правая граница
            right = array.Length - 1;

            while (left <= right)
            {
                int a = 0;
				
				//"всплывает" макс элемент
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
					{
						int value = array[i];
						array[i] = array[i+1];
						array[i+1] = value;
						a++;
					}
                }
				
				//больше не трогаем макc элемент
                right--;
				
				//выходим из сортировки если не произошло ни одной перестановки
                if (a == 0) break;
				
				//мин элемент ставим в начало массива
                for (int i = right; i > left; i--)
                {
                    if (array[i - 1] > array[i])
					{
						int value = array[i];
						array[i] = array[i-1];
						array[i-1] = value;
					}
					
                }
				
				// больше не трогаем мин элемент
                left++;
            }

            return array;
        }

    }
}