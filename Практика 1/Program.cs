using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            double r = 64.100, p1 = 7.8932597F, pr = 100000000000f, f1 = 3.20000, f = 0;
            decimal dec = 18500.5m;
            int s1 = 4, p = 16;
            string s = "AMD", name;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите дробное число: ");
            f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(@"
Привет, {0}!
*********************************
*      Я твой компьютер!        *
*********************************
У меня следующие характеристики:

Процессор                {1} c разрядностью {2:F2}GHz
Моя память               {3}Gb (доступно {4:p0})
Жесткий диск             {5}Tb
Тип системы              {6:f0}-разрядная ОС


Моя производительность   {7:E0} оп/сек
Индекс произв-ти         {8:F0}
Моя стоимость            {9:C2}", name, s, f1, p, p1 / 10, s1, r, pr, f, dec);
            Console.ReadKey();
        }
    }
}
