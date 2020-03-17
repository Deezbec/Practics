using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Program
    {
        static string n3(string s)
        {
            switch (s)
            {
                case "A":
                case "U":
                case "E":
                case "O":
                case "Y":
                case "I":   Console.WriteLine("Гласная");   break;
                default:    Console.WriteLine("Согласная"); break;
            }
        return null;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания ");
            short a = Convert.ToInt16(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        short a1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine((a1 <= 9) ? "Да" : "Нет");
                        break;
                    }
                case 2:
                    {
                        short a1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine((a1 > 0) ? (a1 > 28) ? (a1 < 30) ? "ПОПАЛ!" : "ПЕРЕЛЕТ" : "НЕДОЛЕТ" : "Не бей по своим!");
                        break;
                    }
                case 3:
                    {
                        string s = Console.ReadLine();
                        n3(s);
                        break;
                    }
                case 4:
                    {
                        short a1 = Convert.ToInt16(Console.ReadLine());
                        short a2 = Convert.ToInt16(Console.ReadLine());
                        short a3 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine((a1 == a2) ? "Yes" : (a1 == a3) ? "Yes" : (a2 == a3) ? "Yes" : "No");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
