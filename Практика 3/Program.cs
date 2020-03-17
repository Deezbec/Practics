using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3
{
    class Program
    {
        static void HW()
        {
            int a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine()),
                c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)  Console.WriteLine("{0} {1} {2}", c, b, a);
                    else        Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    if (b > c)  Console.WriteLine("{0} {1} {2}", c, a, b);
                    else        Console.WriteLine("{0} {1} {2}", b, a, c);
                }
            }
            else
            {
                if (a > c)
                {
                    if (b > c)  Console.WriteLine("{0} {1} {2}", c, a, b);
                    else        Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    if (b > c)  Console.WriteLine("{0} {1} {2}", a, c, b);
                    else        Console.WriteLine("{0} {1} {2}", a, b, c);
                }
            }
            Console.ReadKey();
        }
        static void Nc1()
        {
            string s = "", l = "";
            for (short i = 0; i < 10; i++)
            {
                for (short j = 0, a = 2; j < 4; j++, a++)
                {
                    s += a + " x " + (i + 1) + " = " + a * (i + 1) + "\t";
                    l += (a + 4) + " x " + (i + 1) + " = " + (a + 4) * (i + 1) + "\t";
                }
                s += "\n";
                l += "\n";
            }

            Console.WriteLine(s + "\n" + l);
            Console.ReadKey();
        }
        static void Nb1()
        {
            for (short i = 1, k = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1:D2} = {2:D2}     {3} x {4:D2} = {5:D2}     {6} x {7:D2} = {8:D2}     {9} x {10:D2} = {11:D2}",
                    k, i,(k * i), k + 1, i, ((k + 1) * i), k + 2, i, ((k + 2) * i), k + 3, i, ((k + 3) * i));
            }
            Console.WriteLine("");
            for (short i = 1, k = 6; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1:D2} = {2:D2}     {3} x {4:D2} = {5:D2}     {6} x {7:D2} = {8:D2}     {9} x {10:D2} = {11:D2}",
                    k, i, (k * i), k + 1, i, ((k + 1) * i), k + 2, i, ((k + 2) * i), k + 3, i, ((k + 3) * i));
            }
            Console.ReadKey();
        }
        static void Na1()
        {
            for (short i = 0; i < 20; i++)
            {
                for (short j = 0, a = 2; j < 4 && i < 10; j++, a++)
                {
                    Console.Write("{0} x {1:D2} = {2:D2}\t", a, (i + 1), (a*(i + 1)));
                }
                Console.WriteLine("");
                for (short j = 0, a = 6; j < 4 && i >= 10; j++, a++)
                {
                    Console.Write("{0} x {1:D2} = {2:D2}\t", a, (i - 9), (a * (i - 9)));
                }
            }
            Console.ReadKey();
        }
        static void N2()
        {
            for (short i = 1; i <= 9; i++)
                for (int j = i + 1; j <= 9; j++)
                    for (int r = j + 1; r <= 9; r++)
                        Console.Write(i * 100 + j * 10 + r + " ");
            Console.ReadKey();
        }
        static void N3()
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i * 100 + " ");
                Console.Write(i * 101 + " ");
                Console.Write(i * 110 + " ");
                Console.Write(i * 111 + " ");
                for (int j = i + 1; j <= 9; j++)
                {
                    Console.Write(i * 100 + j * 10 + i + " ");
                    Console.Write(i * 100 + i * 10 + j + " ");
                    Console.Write(j * 100 + i * 10 + i + " ");
                    Console.Write(i * 100 + j * 10 + j + " ");
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания ");
            float l = Convert.ToSingle(Console.ReadLine());
            switch(l)
            {
                case 1.1F: Na1(); break;
                case 1.2F: Nb1(); break;
                case 1.3F: Nc1(); break;
                case 2: N2(); break;
                case 3: N3(); break;
                case 0: HW(); break;
            }
        }
    }
}
