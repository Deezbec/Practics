using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    class Program
    {
        static int dop(int a)
        {
            int m = a, k = 0, j = 0, l = 0;
            while (m > 0)
            {
                l = m % 10;
                if (k % 2 == 0) j += l;
                else j -= l;
                m /= 10;
                k++;
            }
            return j;
        }
        static bool pyatoefun(int a)
        {
            int y = 0;
            for (int i = 1; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) y += i + a / i;
            }
            y -= a;
            if (a == y) return true;
            else return false;
        }
        static void perfect(int a)  
        {
            for (int i = 0; i <= a; i++)
            {
                if (pyatoefun(i)) Console.Write($"{i} ");
            }
        }
        static int happyness(int a)
        {
            int m = a, k = 0, l = 0, p = 0;
            while (m > 0)
            {
                k++;
                m /= 10;
            }
            m = a;
            for (int i = 0; i < k; i++)
            {
                int h = m % 10;
                if (k % 2 == 0)
                {
                    if (i < k / 2) l += h;
                    else           p += h;
                }
                else
                {
                    if (i <= k / 2) l += h;
                    if (i >= k / 2) p += h;
                }
                m /= 10;
            }
            if (l == p) return 0;
            else return 1;
        }   
        static int parity(int a)
        {
            int m = a, k = 0;
            while (m > 0)
            {
                int l = m % 10;
                int h = (m / 10) % 10;
                if ((l + h) % 2 == 0) k += l + h;
                m /= 10;
            }
            return k;
        }
        static int kolvo(int a)
        {
            int k = 0, m = a;
            while (m > 0)
            {
                m /= 10;
                int l = m % 10;
                if (l < 8 && l % 3 != 0 && m % 4 != 0) k++;
            }
            return k;
        }
        static void proverka()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a % b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            short p = Convert.ToInt16(Console.ReadLine());
            switch(p)
            {
                case 1:
                {
                    if (kolvo(a) == 0) Console.WriteLine("NO");
                    else Console.WriteLine(kolvo(a));
                    break;
                }
                case 2:
                {
                    Console.WriteLine(parity(a));
                    break;
                }
                case 3:
                {
                        if (happyness(a) == 0) Console.WriteLine("Число является счастливым");
                        else Console.WriteLine("Число не является счастливым");
                        break;
                }
                case 5:
                {
                    perfect(a);
                    break;
                }
                case 6:
                {
                    Console.WriteLine(dop(a));
                    break;
                }
                case 7:
                {
                        proverka();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
