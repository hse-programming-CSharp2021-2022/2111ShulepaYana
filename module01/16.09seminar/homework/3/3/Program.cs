using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(G(x));
        }
        public static double G(double x)
        {
            if (x <= 0.5)
                return Math.Sin(Math.PI / 2);
            return Math.Sin(Math.PI * (x - 1) / 2);
        }
    }
}
