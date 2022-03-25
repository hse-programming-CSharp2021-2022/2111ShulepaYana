using System;

namespace Points
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p)
        {
            return (Math.Sqrt((X * X - p.X * p.X) + (Y * Y - p.Y * p.Y)));
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }

    public class Circle
    {
        public Point center;
        private double rad;

        public double Rad
        {
            get { return rad; }
            set { rad = value; }
        }

        public Circle(double rad, double x, double y)
        {
            center = new Point(x, y);
            Rad = rad;
        }

        public override string ToString()
        {
            return $"Radius: {Rad}, {center}";
        }
    }
}