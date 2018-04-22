using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace sorts
{
    class Program
    {
        public static long iteration = 0;
        public static double time;

        public static int[] BubbleSort(int[] data)
        {
            iteration = 0;

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
			
            bool swaps = true;
			// пробегаем по массиву
            for (int i = 0; i < data.Length; i++)
            {
				// если при проходе не произоло ни одной перестановки,
				// то массив отсортирован
                if (!swaps) break;
                swaps = false;
				
                for (int j = 0; j < data.Length - i - 1; j++)
                {
					// меняем значения, если они стоят в неправильном порядке
                    if (data[j] > data[j + 1])
                    {
                        int highValue = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = highValue;
                        swaps = true;
                    }
                }
            }
            sw.Stop();
            time = sw.Elapsed.TotalMilliseconds;
            return data;

        }
        public static int[] combSort(int[] data)
        {

            System.Diagnostics.Stopwatch sw = new Stopwatch();
			
            double gap = data.Length;
            bool swaps = true;
            iteration = 0;
            sw.Start();
            while (gap > 1 || swaps)
            {
				// уменьшаем разрыв между сравниваемыми элементами
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
				
				// проходим по массиву с разрывром в gap
                while (i + gap < data.Length)
                {
                    int igap = i + (int)gap;
					
					// меняем значения, если они стоят в неправильном порядке
                    if (data[i] > data[igap])
                    {
                        int swap = data[i];
                        data[i] = data[igap];
                        data[igap] = swap;
                        swaps = true;
                    }
                    i++;
                    iteration++;
                }

            }
            sw.Stop();
            time = sw.Elapsed.TotalMilliseconds;
            return data;
        }

        static void Main(string[] args)
        {
			
            StreamReader sr = new StreamReader(@"randmass.txt");
            StreamWriter swData = new StreamWriter(@"sortmass.txt");
            StreamWriter swTime = new StreamWriter(@"time.txt");
            StreamWriter swIteration = new StreamWriter(@"iteration.txt");

			// читаем массивы, сортируем их и записываем в файлы результаты
            for (int i = 100; i < 10000; i += 50)
            {
                string str = sr.ReadLine();
                string[] dataString = new string[i+1];
                
                dataString = str.Split(' ');

                int[] data = new int[dataString.Count()];

                for (int j = 0; j < dataString.Count(); j++)
                    if(dataString[j]!="")
                        data[j] = int.Parse(dataString[j]);

                data = BubbleSort(data);
                for (int j = 0; j < dataString.Count(); j++)
                    swData.Write("{0} ", data[j]);
                swData.WriteLine();
                swTime.WriteLine(time);
                swIteration.WriteLine(iteration);
            }

            sr.Close();
            swData.Close();
            swTime.Close();
            swIteration.Close();
        }
    }
}
