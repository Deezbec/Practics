using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_13_Наследование
{
    class DemoPoint
    {
        int x1;
        int y1;
        public DemoPoint()
        {
            x1 = 0;
            y1 = 0;
        }
        public DemoPoint(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public int X {get{ return this.x1; } }
        public int Y {get{ return this.y1; } }
        public void show()
        {
            Console.WriteLine($"Координаты 1ой точки : ({x1}; {y1})");
        }
    }
    class DemoLine : DemoPoint
    {
        int x2;
        int y2;
        public DemoLine() : base()
        {
            x2 = 0;
            y2 = 0;
        }
        public DemoLine(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public int X2 { get { return this.x2; } }
        public int Y2 { get { return this.y2; } }
        new public void show()
        {
            base.show();
            Console.WriteLine($"Координаты 2ой точки : ({x2}; {y2})");
        }
    }
    class Program
    {
        static bool XY(ref int x, ref int y)
        {
            string[] s;
            try
            {
                s = Console.ReadLine().Split();
                if(s.Length != 2) throw new Exception("Неверное количество чисел");
                if (!Int32.TryParse(s[0], out x) || !Int32.TryParse(s[1], out y)) throw new Exception("Число не может состоять из букв");
                return false;
            }
            catch (Exception Error)
            {
                Console.WriteLine($"Ошибка : {Error.Message}");
                return true;
            }
        }
        static void Main(string[] args)
        {
            int x = 0, y = 0, squareSide = 0;
            DemoPoint firstOne;
            DemoLine secondOne;
            Console.Write("Хотите задать координаты 1ой точки? ");
            if (Console.ReadLine().ToLower().Replace("l", "д").Replace("f", "а") == "да")
            {
                Console.WriteLine("Введите координаты x и y через пробел\nПример : 13 26");
                while (XY(ref x, ref y)) ;
                firstOne = new DemoPoint(x, y);
                if (x > y) squareSide = x; else squareSide = y;
            }
            else firstOne = new DemoPoint();
            Console.Write("Хотите задать координаты 2ой точки? ");
            if (Console.ReadLine().ToLower().Replace("l", "д").Replace("f", "а") == "да")
            {
                Console.WriteLine("Введите координаты x и y через пробел\nПример : 13 26");
                while (XY(ref x, ref y)) ;
                secondOne = new DemoLine(firstOne.X, firstOne.Y, x, y);
                if (x > y) { if (x > squareSide) squareSide = x; }
                else if (y > squareSide) squareSide = y;
            }
            else secondOne = new DemoLine();
            Console.WriteLine("Метод класса DemoPoint : ");
            firstOne.show();
            Console.WriteLine("Метод дочернего класса DemoPoint — DemoLine : ");
            secondOne.show();
            Console.Write("К сожалению, вы сможете увидеть только точки, находящиеся в 1ой части ДСК\n");
            for (int i = squareSide; i < (squareSide * squareSide + squareSide); i++) 
            {
                if (i % squareSide == 0) { Console.WriteLine(""); Console.Write($"{(squareSide + 1) - i / squareSide:D2} "); }
                if ((((i - squareSide) % squareSide) + 1 == secondOne.X && squareSide - ((i - squareSide) / squareSide) == secondOne.Y) ||
                    (((i - squareSide) % squareSide) + 1 == secondOne.X2 && squareSide - ((i - squareSide) / squareSide) == secondOne.Y2)) 
                    { Console.ForegroundColor = ConsoleColor.Red; Console.Write("▓▓"); Console.ResetColor(); }
                else Console.Write("▓▓");
            }
            Console.WriteLine();
            for (int i = 0; i <= squareSide; i++)
            {
                if (i == 0) Console.Write("   ");
                if (i != 0 && i < 10) Console.Write($" {i}");
                //if (i >= 10) Console.Write($"{i}"); // Варинат с двухзначными цифрами (сливаются)
                if (i >= 10) Console.Write($" {(char)(65 + i - 10)}"); // Вариант с буквами (A B C D и т.д.) для того чтобы двухзначные цифры не сливались
            }
            Console.WriteLine($"\nДлина прямой — {Math.Sqrt(Math.Pow(Math.Abs(secondOne.X - secondOne.X2), 2) + Math.Pow(Math.Abs(secondOne.Y - secondOne.Y2), 2)):F2}");
            Console.ReadKey();
        }
    }
}
