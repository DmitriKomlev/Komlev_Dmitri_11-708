using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace kr1
{
    //
    public class class1
    {
        //не должен сериализовать 
        public static void qwrtet()
        { }
        //не должен сериализовать
        public static void asxe()
        { }
        public static void xsdc()
        { }
        public static void cdfv()
        { }
    }
    public class class2
    {
        public static string name;
        public static int age;

        public static void Method2()
        { }

        public static void Method1()
        { }
        public static void Method3()
        { }
        //не должен сериализовать
        public static void Metod4()
        { }
        //не должен сериализовать
        public class2(string n, int a)
        {
            name = n;
            age = a;
        }
    }

    public class Program
    {


        public static void Main()
        {
            // список coгласных
            char[] letters = { 'q', 'w', 'r', 't', 'p', 's','d', 'f', 'g', 'h','k', 'l', 'z','x','c','v','b','n','m','j' };
            var list = new List<object>
            {
                new class1(),
                new class2("sd", 12)
                
            };
            foreach (var obj in list)
            {
                var type = obj.GetType();

                // получаем property по очереди
                foreach (var property in type.GetMethods())
                {
                   //счетчик согласных 
                    int k = 0;

                    // подсчет всех согласных
                    foreach (var e in property.Name.ToLower())
                        if (letters.Contains(e))
                            k++;
                    //выводим если их четное кол-во
                    if (((double)k % 2 == 0))
                    { 
                        var str1 = JsonConvert.SerializeObject(property);
                        Console.WriteLine(str1);
                        Console.WriteLine();
                    }
                }
            }             
            Console.ReadKey();
        }
    }
}
