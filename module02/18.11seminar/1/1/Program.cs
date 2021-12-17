using System;
using ClassLibrary;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[4] {new Point(0, 0), new Point(0, 4), new Point(4, 0 ), new Point(4,4)};
            Square a = new Square(points);
            Console.WriteLine(a);
        }
    }
}
