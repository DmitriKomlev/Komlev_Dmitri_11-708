using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace sortBucket
{
    class Program
    {
        public static long iteration = 0;
        public static double time;

        public static void Main(string[] args)
        {
            StreamReader data = new StreamReader(@"randmass.txt");
            StreamWriter sortMass = new StreamWriter(@"sortmass.txt");
            StreamWriter time = new StreamWriter(@"time.txt");
            StreamWriter iteration = new StreamWriter(@"iteration.txt");

            for (int i = 100; i < 10000; i += 50)
            {
                string str = data.ReadLine();
                string[] dataString = new string[i + 1];

                dataString = str.Split(' ');

                int[] data = new int[dataString.Count()];

                for (int j = 0; j < dataString.Count(); j++)
                    if (dataString[j] != "")
                        data[j] = int.Parse(dataString[j]);

                data = BucketSort(ref data);
                for (int j = 0; j < dataString.Count(); j++)
                    sortMass.Write("{0} ", data[j]);
                sortMass.WriteLine();
                time.WriteLine(time);
                iteration.WriteLine(iteration);
            }
            data.Close();
            sortMass.Close();
            time.Close();
            iteration.Close();
        }

        public static int[] BucketSort(ref int[] data)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            iteration = 0;

            //находим мин и макс значения в массиве
			//начиая с 1го элемента
            int minValue = data[0]; 
            int maxValue = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > maxValue)
                    maxValue = data[i];
                iteration++;
                if (data[i] < minValue)
                    minValue = data[i];
                iteration++;
            }

            //создаем временное "ведро" для хранения значений
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            //заполняем
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
                iteration++; 
            }

            //меняем местами элементы
            for (int i = 0; i < data.Length; i++)
            {
                bucket[data[i] - minValue].Add(data[i]);
                iteration++;
            }

            //перемещаем элемент в исхоный массив
            int k = 0;  
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        data[k] = bucket[i][j];
                        k++;
                        iteration++;
                    }
                }
            }
            sw.Stop();
            time = sw.Elapsed.TotalMilliseconds;
            return data;
        }
    }
}