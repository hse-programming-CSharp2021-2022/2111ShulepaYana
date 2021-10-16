using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(G(x, y));
        }
        public static bool G(double x, double y)
        {
            if ((y >= -2) && (y <= Math.Pow(2, 0.5)) && (x >= 0) && (x <= Math.Pow(2, 0.5)))
                return true;
            return false;
        }
    }
}
