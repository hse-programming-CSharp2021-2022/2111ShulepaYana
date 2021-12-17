using System;

namespace ClassLibrary
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
        public override string ToString()
        {
            return $"x = {X}; y = {Y}";
        }
    }

    public abstract class Figure
    {
        public Point[] points { get; set; }
        public virtual double Length { get; }
        public abstract double Area();

        public Figure(Point[] allPoints)
        {
            points = new Point[allPoints.Length];
            for (int i = 0; i < allPoints.Length; i++)
                points[i] = allPoints[i];
        }

        public Point CircleCenter()
        {
            double allX = 0;
            double allY = 0;
            for (int i = 0; i < points.Length; i++)
            {
                allX += points[i].X;
                allY += points[i].Y;
            }
            return new Point(allX / points.Length, allY / points.Length);
        }

        public abstract double Radius();

        public bool Cross(Figure second)
        {
            double distance = Math.Sqrt(Math.Pow(CircleCenter().X-second.CircleCenter().X, 2) 
                                        + Math.Pow(CircleCenter().Y-second.CircleCenter().Y, 2));
            if (distance <= this.Radius() + second.Radius())
                return true;
            return false;
        }

        public override string ToString()
        {
            string point = "";
            foreach (Point el in points)
                point += el + "; ";
            return $"{point} {this.Length}; {this.GetType()}; {Area()}";
        }
    }

    public class EqTriangle : Figure
    {
        public EqTriangle(Point[] allPoints) : base(allPoints) {}

        public override double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2)
                                 + Math.Pow(points[0].Y - points[1].Y, 2));
            }
        }

        public override double Area()
        {
            return Math.Sqrt(3) * Length * Length / 4;
        }

        public override double Radius()
        {
            return 2*Length / Math.Sqrt(3);
        }
    }

    public class Square : Figure
    {
        public Square(Point[] allPoints) : base(allPoints) {}
        public override double Length
        {
            get
            {
                double a = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2)
                                     + Math.Pow(points[0].Y - points[1].Y, 2));
                double b = Math.Sqrt(Math.Pow(points[0].X - points[2].X, 2)
                                     + Math.Pow(points[0].Y - points[2].Y, 2));
                if (a >= b)
                    return b;
                return a;
            }
        }
        public override double Area()
        {
            return Length * Length;
        }
        public override double Radius()
        {
            return Length / Math.Sqrt(2);
        }
    }
}