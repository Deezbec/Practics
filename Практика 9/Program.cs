using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_9
{
    class Program
    {
        static int Recurs(int m)
        {
            if (m == 0) return 0;
            if (m == 1) return 1;
            int fib1 = Recurs(m - 1);
            int fib2 = Recurs(m - 2);
            return fib1 + fib2;
        }//*/
        static void NotRecurs(int m, out int s)
        {
            int a = 1, b = 1;
            s = 1;
            Console.Write("1");
            while(b <= m)
            {
                s += b;
                b += a;
                a = b - a;
                Console.Write($" + {a}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("M = ");
            int m = Convert.ToInt32(Console.ReadLine()), s = 0, k;
            Console.WriteLine(@"Если вы хотите увидеть рекурсивное решение, введите 1
Если вы хотите увидеть итерационное решение, введите 0");
            int chooser = Convert.ToInt32(Console.ReadLine());
            switch(chooser)
            {
                case 0:
                    {
                            Console.Write($"S = ");
                            NotRecurs(m, out s);
                            Console.WriteLine($" = {s}");
                            break;
                    }
                case 1:
                    {
                            Console.Write($"S = ");
                            s = 0;
                            Console.Write("0");
                            for (int i = 1; m >= Recurs(i); i++)
                            {
                                k = Recurs(i);
                                s += k;
                                Console.Write($" + {k}");
                            }
                            break;
                    }
            }
            Console.WriteLine($" = {s}");
            Console.ReadKey();
        }
    }
}
