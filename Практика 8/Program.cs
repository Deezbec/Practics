using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_8
{
    class Program
    {
        static void changer(ref int a, ref int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }
        static void sequence (ref int a, ref int b, ref int c)
        {
            /*
            if (a >= b)
            {
                if (a < c)
                {
                    changer(ref a, ref c);
                    changer(ref b, ref c);
                }
                else
                    if (c > b) changer(ref c, ref b);
            }
            else
            {
                if (b > c)
                {
                    changer(ref a, ref b);
                    if (b < c) changer(ref b, ref c);
                }
                else
                    changer(ref a, ref c);
                    
            }//Нерационадбный вариант через вложенные условия*/
            while(a <= b || a <= c || b <= c)
            {
                changer(ref a, ref b);
                if (b < c) changer(ref b, ref c);
            }
        }
        static void multiplication(ref int a, int b)
        {
            int k = 1;
            while (b > 0)
            {
                k *= 10;
                b /= 10;
            }
            a *= k;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.Write("a = ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b = ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        multiplication(ref a, b);
                        Console.WriteLine(a);
                        break;
                    }
                case 2:
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write("a = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("b = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.Write("c = ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            sequence(ref a, ref b, ref c);
                            Console.WriteLine($"a = {a} b = {b} c = {c}");
                            if (j != 5)
                            {
                                Console.WriteLine("Хотите ли вы попробовать еще раз?");
                                string s = Console.ReadLine();
                                if (s != "да") break;
                            }
                        }
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
