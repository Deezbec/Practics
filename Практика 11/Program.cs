using System;
// Вариант 4
namespace Практика_11
{
    class Program
    {
        enum CHAPTERS { Зима = 0, Весна, Лето, Осень };
        enum nMonths
        { Январь = 31, Февраль = 28, Март = 31, Апрель = 30, Май = 31, Июнь = 30, Июль = 31, Август = 31, Сентябрь = 30, Октябрь = 31, Ноябрь = 30, Декабрь = 31 };
        enum Months { Январь = 1, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь }
        static void Main(string[] args)
        {
            for (Months k = Months.Январь; k <= Months.Декабрь; k++)
                Console.WriteLine($"Месяц: \"{k}\", соответствует числу {(int)k}");
            Console.Write("Введите номер месяца : ");
            Months res = (Months)Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер дня : ");
            int NumDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько дней нужно отсчитать? ");
            int NumCount = Convert.ToInt32(Console.ReadLine()), i;
            int[] mass = new int[] { 0, (int)nMonths.Январь, (int)nMonths.Февраль, (int)nMonths.Март, (int)nMonths.Апрель, (int)nMonths.Май, (int)nMonths.Июнь, (int)nMonths.Июль, (int)nMonths.Август, (int)nMonths.Сентябрь, (int)nMonths.Октябрь, (int)nMonths.Ноябрь, (int)nMonths.Декабрь };
            for (i = 1; i < mass.Length; i++) if (i == (int)res) break;
            nMonths g = nMonths.Февраль;
            for (Months k = Months.Январь; k <= Months.Декабрь; k++, g++)
                if(Convert.ToString(k) == Convert.ToString(g)) break;
            for (; NumCount > 0; NumCount--, NumDay++) { if (i == 13) i = 1; if (NumDay == mass[i]) { i++; NumDay = 0; } }
            i++;
            if (i > 12) i -= 12;
            Console.WriteLine((CHAPTERS)(i / 3));
            Console.ReadKey();
        }
    }
}
