using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgs
{
    class Program
    {
        static void delit()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Math.Sqrt(a); i++)
                if (a % i == 0) Console.Write((a / i == a) ? $"{i} {a / i} " : $"{i} ");
        }
        static void prost()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    k++;
                    break;
                }
            }
            if (k == 0) Console.WriteLine("Простое");
            else Console.WriteLine("Непростое");
        }
        static void SelectSort()
        {
            int[] a = new int[] { 7, 0, -4, 3, 1, -2, 5 };
            int min;
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool flag = false;
                min = i;
                for (int j = i + 1; j < a.Length; j++) if (a[j] < a[min])
                    {
                        min = j;
                        flag = true;
                    }
                if (flag)
                {
                    a[i] -= a[min];
                    a[min] += a[i];
                    a[i] = a[min] - a[i];
                }
            }
            foreach (int x in a)
                Console.Write($"{x} ");
        }

        static void Artyom()
        {
            int[] a = new int[] { 7, 0, -4, 3, 1, -2, 5 };
            int min;
            int temp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool flag = false;
                min = a[i];
                for (int j = i + 1; j < a.Length; j++) if (a[j] < min)
                    {
                        min = a[j];
                        flag = true;
                    }
                if (flag == true)
                {
                    temp = min;
                    min = a[i];
                    a[i] = temp;
                }
            }
            foreach (int x in a)
                Console.Write($"{x} ");
        }
        static void del()
        {
            int k = 12;
            int[] a = new int[] {3, 5, 7, 4, 6, 3, 2, 1, 7, 6, 4, 5, 7};
            for (int i = k; i < a.Length - 1; i++)
                a[i] = a[i + 1];
            foreach (int x in a)
                Console.Write($"{x} ");
        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1: delit(); break;
                case 2: prost(); break;
                case 3: SelectSort(); break;
                case 4: Artyom(); break;
                case 15: del(); break;
            }
            Console.ReadKey();
        }
    }
}
