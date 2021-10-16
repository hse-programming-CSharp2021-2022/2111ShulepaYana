using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(First(x));
            Console.WriteLine(Second(x));

        }
        static int Factorial(int a)
        {
            if (a == 0)
                return 1;
            else
            {
                int s = 1;
                for (int i = 1; i < a+1; i++)
                {
                    s *= i;
                }
                return s;
            }
        }
        static double First(double x)
        {
            double s1 = Math.Pow(x, 2);
            double s2 = 0;
            int n = 1;
            int sign = 1;
            int k = 3;
            while (s1 - s2 != 0)
            {
                if (n % 2 != 0)
                    sign = -1;
                else
                    sign = 1;
                n++;
                s2 = s1;
                s1 += sign * (Math.Pow(2, k) * Math.Pow(x, k + 1) / Factorial(k + 1));
                k += 2;
                if (k >= 30)
                {
                    Console.WriteLine("Не удалось посчитать, займёт слишком большое время (или число выходит слишком большим). Остановились на:");
                    break;
                }
            }
            return s1;
        }
        static double Second(double x)
        {
            double s1 = 1;
            double s2 = 0;
            int n = 1;
            while (s1 - s2 != 0)
            {
                s2 = s1;
                s1 += Math.Pow(x, n) / Factorial(n);
                n++;
                if (n >= 20)
                {
                    Console.WriteLine("Не удалось посчитать, займёт слишком большое время (или число выходит слишком большим). Остановились на:");
                    break;
                }
            }
            return s1;
        }
    }
}
