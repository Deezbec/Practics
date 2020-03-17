using System;
//Вариант 7
namespace Практика_12
{
    class Program
    {
        struct TNote { public string Descript; public int Month; public int Day; public int Hour; public int Minute; }
        static bool Days(TNote User, ref int counter)
        {
            int[] nMonths = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string s = Convert.ToString(DateTime.Now);
            int monthsec = (s[3] - '0') * 10 + s[4] - '0', daysec = (s[0] - '0') * 10 + (s[1] - '0'), Hoursec = (s[11] - '0') * 10 + s[12] - '0', Minutesec = (s[14] - '0') * 10 + s[15] - '0';
            if (monthsec > User.Month || (daysec > User.Day && monthsec == User.Month) || (daysec == User.Day && monthsec == User.Month && (Hoursec > User.Hour || (Hoursec == User.Hour && Minutesec > User.Minute)))) return false;
            else
            {
                while (monthsec != User.Month || daysec != User.Day)
                {
                    if (daysec == nMonths[monthsec]) { monthsec++; daysec = 0; }
                    daysec++;
                    counter++;
                }
                return true;
            }
        }
        static string[] ForString()
        {
            string[] s = Console.ReadLine().Replace(".", " ").Replace(":", " ").Split();
            while (s.Length != 2) s = Console.ReadLine().Replace(".", " ").Replace(":", " ").Split();
            return s;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                bool flag = true;
                TNote User;
                Console.Write("Текст Напоминания : ");
                User.Descript = Console.ReadLine();
                Console.Write("Дата выполнения : ");
                string[] s = ForString();
                User.Day = Convert.ToInt32(s[0]);
                User.Month = Convert.ToInt32(s[1]);
                Console.Write("Время выполнения : ");
                s = ForString();
                User.Hour = Convert.ToInt32(s[0]);
                User.Minute = Convert.ToInt32(s[1]);
                if (User.Month < 1 || User.Month > 12 || User.Day > 31) { Console.WriteLine("Такая дата невозможна!"); flag = false; }
                if (User.Hour > 24 || User.Minute > 59) { Console.WriteLine("Время указано неверно!"); flag = false; }
                if (flag)
                {
                    int counter = 0;
                    if (Days(User, ref counter)) Console.WriteLine($"До события осталось {counter} дней");
                    else                         Console.WriteLine("Вы опоздали");
                    Console.WriteLine(@$"√°^°
Напоминание :   {User.Descript}
Дата        :   {User.Day:D2}.{User.Month:D2}
Время       :   {User.Hour:D2}:{User.Minute:D2}");
                }
                Console.Write("Есть ли еще события? ");
                if (Console.ReadLine() != "да") break;
            }
        }
    }
}
