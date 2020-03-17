using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_5
{
    class Program
    {
        static int res(short n)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int mx = (int)Math.Pow(2, 31) - 1;
            for (int i = 0; i < n - 1; i ++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                if (a * b < mx) mx = a * b;
                a = b;
            }
            return mx;
        }
        static void Main(string[] args)
        {
            short n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(res(n));
            Console.ReadKey();
        }
    }
}
