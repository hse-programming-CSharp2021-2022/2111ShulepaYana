using System;

namespace _2
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public Point() : this(0, 0) { }

            public double Ro
            {
                get
                {
                    return Math.Sqrt(X * X + Y * Y);
                }
            }

            public double Fi
            {
                get
                {
                    if (X > 0 && Y >= 0)
                        return Math.Atan(Y / X);
                    if (X > 0 && Y < 0)
                        return Math.Atan(Y / X) + 2 * Math.PI;
                    if (X < 0)
                        return Math.Atan(Y / X) + Math.PI;
                    if (X - 1e-10 == 0 && Y > 0)
                        return Math.PI / 2;
                    if (X - 1e-10 == 0 && Y < 0)
                        return 3 * Math.PI / 2;
                    return 0;
                }
            }

            public string PointData
            {
                get
                {
                    string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                    return String.Format(maket, X, Y, Ro, Fi);
                }
            }
        }
        static void Main(string[] args)
        {
            Point a, b, c;
            a = new Point(3, 4);
            b = new Point(0, 3);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x;
                c.Y = y;
                if (a.Ro > b.Ro && a.Ro > c.Ro)
                {
                    if (b.Ro > c.Ro)
                    {
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(a.PointData);
                    }
                    else
                    {
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(a.PointData);
                    }
                }
                if (b.Ro > a.Ro && b.Ro > c.Ro)
                {
                    if (a.Ro > c.Ro)
                    {
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(b.PointData);
                    }
                    else
                    {
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(c.PointData);
                        Console.WriteLine(b.PointData);
                    }
                }
                if (c.Ro > a.Ro && c.Ro > b.Ro)
                {
                    if (a.Ro > b.Ro)
                    {
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(c.PointData);
                    }
                    else
                    {
                        Console.WriteLine(a.PointData);
                        Console.WriteLine(b.PointData);
                        Console.WriteLine(c.PointData);
                    }
                }
            } while (x != 0 | y != 0);
        }
    }
}
