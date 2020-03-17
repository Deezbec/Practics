using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_10
{
    class Program
    {
        static void MostPop(string s)
        {
            Console.Write("Введите 1ый символ : ");
            char a = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите 2ой символ : ");
            char b = Convert.ToChar(Console.ReadLine());
            int k = 0;
            while(s.Contains(a) || s.Contains(b))
            {
                if (s.IndexOf(a) != -1)
                {
                    s = s.Remove(s.IndexOf(a), 1);
                    k++;
                }
                if (s.IndexOf(b) != -1)
                {
                    s = s.Remove(s.IndexOf(b), 1);
                    k--;
                }
            }
            if(k == 0) Console.WriteLine($"Символы встречаются одинаковое количество раз");
            else
            {
                if (k > 0) Console.WriteLine($"Символ '{a}' встречается чаще всего");
                else Console.WriteLine($"Символ '{b}' встречается чаще всего");
            }
        }
        static void TyperBeforeTwoDots (ref string s)
        {
            s = s.Remove(s.IndexOf(':'));
        }
        static void Main(string[] args)
        {
            Console.Write("Номер задания : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Исходная строка : ");
            string s = Console.ReadLine();
            switch (a)
            {
                case 1:
                    {
                        TyperBeforeTwoDots(ref s);
                        Console.WriteLine($"Новая строка : {s}"); break;
                    }
                case 2: MostPop(s); break;
            }
            Console.ReadKey();
        }
    }
}
