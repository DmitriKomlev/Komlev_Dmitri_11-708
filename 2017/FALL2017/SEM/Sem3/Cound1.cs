using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cound1
{
    class Program
    {
        enum Chess { king=1, knight, queen, bishop, rook }
        /*public static bool IsCorrectMoveForQueen(string from, string to) //провека для ферзя
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали 
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали 
            if (to == from) return false;
            else
            if (dx * dy == 0) return true;
            else if (dx == dy) return true;
            else return false;
        }
        public static bool IsCorrectMoveForRook(string from, string to) //проверка для ладьи
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали 
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали 
            if (to == from) return false;
            else
            if (dx * dy == 0) return true;

            else return false;
        }
        public static bool IsCorrectMoveForbishop(string from, string to) //проверка для слона
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали 
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали 
            if (to == from) return false;
            else if (dx == dy) return true;
            else return false;
        }
        public static bool IsCorrectMoveForHorse(string from, string to) //проверка для коня
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали 
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали 
                                                
            if ((dx == 2) && (dy == 1)) return true;
            if ((dx == 1) && (dy == 2)) return true;
            return false;
        }
        public static bool IsCorrectMoveForKing(string from, string to) //проверка для короля
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали 
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали 

            if ((dx <= 1) && (dy <= 1)) return true;
            
            return false;
        }*/
        private static bool IsWayCorrect(Chess chess, string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали 
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали 
            switch(chess)
            {
                case Chess.king:
                    return ((dx <= 1) && (dy <= 1));
                case Chess.knight:
                    return (((dx == 2) && (dy == 1)) || ((dx == 1) && (dy == 2)));
                case Chess.queen:
                    return ((to == from) && ((dx * dy == 0) || (dx == dy)));
                case Chess.bishop:
                    return (dx == dy);
                case Chess.rook:
                    return (dx * dy == 0);
                default:
                    return false;

            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("enter number of your figure, pls(1)king, 2)knight, 3)queen, 4)bishop, 5)rook):");
            Chess chess = (Chess)int.Parse(Console.ReadLine());
            string from, to;
            from = Console.ReadLine();
            to = Console.ReadLine();
            Console.WriteLine(IsWayCorrect(chess, from, to));
            
            Console.ReadLine();


        }
    }
}
