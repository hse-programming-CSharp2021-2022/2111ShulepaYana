using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(G(x, y));

        }
        public static double G(double x, double y)
        {
            if ((x < y) && (x > 0))
                return x + Math.Sin(y);
            if ((x > y) && (x < 0))
                return y - Math.Cos(x);
            return 0.5 * x * y;
        }
    }
}
