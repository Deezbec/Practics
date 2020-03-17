using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_4
{
    class Program
    {
        static double max(double a, double b, double c)
        {
            double max = a;
            if (max < b)    max = b;
            if (max < c)    max = c;
            return max;
        }
        static double min(double a, double b)
        {
            return a < b? a : b;
        }
        static void Main(string[] args)
        {
            int    a = Convert.ToInt32(Console.ReadLine()),
                   b = Convert.ToInt32(Console.ReadLine());
            double c = max(Math.Pow(min((a + 1) / a, b), 2), a, 2F / (a * b)) * min(a, max(0, -b, Math.Sqrt(1 + a * b))) 
                + 2 * max(a, 3 + Math.Sqrt(a), Math.Pow(a, 3) * b);
            Console.WriteLine("{0:F2}", c);
            Console.ReadKey();
        }
    }
}
