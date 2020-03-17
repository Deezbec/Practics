using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_7
{
    class Program
    {
        static void toTwo()
        {
            sbyte a = Convert.ToSByte(Console.ReadLine()), b = 1;
            for (int i = 7; i >= 0; i--)
            {
                //if (((short)Math.Pow(2, (double)i) & a) == (short)Math.Pow(2, (double)i))
                if (((b << i) & a) == (b << i))
                    Console.Write("1");
                else Console.Write("0");
            }   
        }
        static int getvalN(int x, int n)
        {
            int b = 1 << n;
            //if (((short)Math.Pow(2, (double)n) & x) == (short)Math.Pow(2, (double)n))
            if ((x & b) == b)
                return 1;
            else return 0;
        }
        static void Table()
        {
            sbyte a = Convert.ToSByte(Console.ReadLine()),
                 b = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine($@"
a&b   a|b    a^b   ~a     ~b   a<<1  b>>2
{a & b}     {a | b}     {a ^ b}    {~a:D}    {~b:D}   {a << 1}    {b >> 2}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания ");
            byte a = Convert.ToByte(Console.ReadLine());
            switch (a)
            {
                case 1: Table(); break;
                case 2:
                    {
                        short x = Convert.ToInt16(Console.ReadLine()),
                              n = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine($"В {n} разряде находится {getvalN(x, n)}"); break;
                    }
                case 3: toTwo(); break;
            }
            Console.ReadKey();
        }
    }
}
