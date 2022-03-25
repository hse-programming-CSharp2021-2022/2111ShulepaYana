using System;
using Dots;

namespace pres2a_page22
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Dot D = new Dot(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }

        public static void PrintInfo(Dot A)
        {
            Console.WriteLine($"X: {A.X}, Y: {A.Y}");
        }
    }
}