using System;
using System.Diagnostics;
using System.Drawing;

namespace RefactorMe
{
    // ## Прочитайте! ##
    //
    // Ваша задача привести код в этом файле в порядок. 
    // Для начала запустите эту программу.
    // Переименуйте всё, что называется неправильно. Это можно делать комбинацией клавиш Ctrl+R, Ctrl+R (дважды нажать Ctrl+R).
    // Повторяющиеся части кода вынесите во вспомогательные методы. Это можно сделать выделив несколько строк кода и нажав Ctrl+R, Ctrl+M
    // Избавьтесь от всех зашитых в коде числовых констант — положите их в переменные с понятными именами.
    // 
    // После наведения порядка проверьте, что ваш код стал лучше. 
    // На сколько проще после ваших переделок стало изменить размер фигуры? Повернуть её на некоторый угол? 
    // Научиться рисовать невозможный треугольник, вместо квадрата?

    class Risovatel
    {
        static Bitmap image = new Bitmap(800, 600);
        static float xCoor, yCoor;
        static Graphics graphics;

        public static void Create_file()
        {
            image = new Bitmap(800, 600);
            graphics = Graphics.FromImage(image);
        }

        public static void Set_pos(float x0, float y0)
        {
            xCoor = x0;
            yCoor = y0;
        }

        public static void Draw_line(double length, double angle)
        {
            //Делает шаг длиной L в направлении angle и рисует пройденную траекторию
            var x1 = (float)(xCoor + length * Math.Cos(angle));
            var y1 = (float)(yCoor + length * Math.Sin(angle));
            graphics.DrawLine(Pens.Green, xCoor, yCoor, x1, y1);
            xCoor = x1;
            yCoor = y1;
        }

        public static void ShowResult()
        {
            image.Save("result.bmp");
            Process.Start("result.bmp");
        }
    }

    public class StrangeThing
    {

        public static void Draw_Part_Squere(float x, float y,int k)
        {
            double pi1 =0;
            for( int i = 1; i<k;++i)
            {
                pi1+= Math.PI / 2;
            }
            //Console.WriteLine(pi1);
            Risovatel.Set_pos(x, y);
            Risovatel.Draw_line(100, pi1);
            Risovatel.Draw_line(10 * Math.Sqrt(2), pi1 + Math.PI / 4);
            Risovatel.Draw_line(100, pi1+ Math.PI);
            Risovatel.Draw_line(100 - (double)10, pi1+Math.PI / 2);
            //pi1 += Math.PI / 2;
        }
        public static void Main()
        {
            
            Risovatel.Create_file();
            /*
            //Рисуем четыре одинаковые части невозможного квадрата.
            // Часть первая:
            Risovatel.Set_pos(10, 0);
            Risovatel.Draw_line(100, 0);
            Risovatel.Draw_line(10 * Math.Sqrt(2), Math.PI / 4);
            Risovatel.Draw_line(100, Math.PI);
            Risovatel.Draw_line(100 - (double)10, Math.PI / 2);

            // Часть вторая:
            Risovatel.Set_pos(120, 10);
            Risovatel.Draw_line(100, Math.PI / 2);
            Risovatel.Draw_line(10 * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Risovatel.Draw_line(100, Math.PI / 2 + Math.PI);
            Risovatel.Draw_line(100 - (double)10, Math.PI / 2 + Math.PI / 2);

            // Часть третья:
            Risovatel.Set_pos(110, 120);
            Risovatel.Draw_line(100, Math.PI);
            Risovatel.Draw_line(10 * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Risovatel.Draw_line(100, Math.PI + Math.PI);
            Risovatel.Draw_line(100 - (double)10, Math.PI + Math.PI / 2);

            // Часть четвертая:
            Risovatel.Set_pos(0, 110);
            Risovatel.Draw_line(100, -Math.PI / 2);
            Risovatel.Draw_line(10 * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Risovatel.Draw_line(100, -Math.PI / 2 + Math.PI);
            Risovatel.Draw_line(100 - (double)10, -Math.PI / 2 + Math.PI / 2);
            */
            Draw_Part_Squere(10, 0, 1);
            Draw_Part_Squere(120, 10, 2);
            Draw_Part_Squere(110, 120, 3);
            Draw_Part_Squere(0, 110, 4);
            
            Risovatel.ShowResult();
            //Console.ReadLine();
        }
    }
}