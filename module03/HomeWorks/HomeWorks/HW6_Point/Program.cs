using System;
using System.Collections.Generic;
using Points;

namespace HW6_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> list = new List<Circle>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(1, 8); i++)
            {
                list.Add(new Circle(rnd.Next(1, 9), rnd.Next(-10, 11), rnd.Next(-10, 11)));
            }
            list.Sort((p1, p2) =>
            {
                if (p1.Rad * p1.center.Distance(new Point(0, 0)) < p2.Rad * p2.center.Distance(new Point(0, 0))) return 1;
                if (p1.Rad * p1.center.Distance(new Point(0, 0)) > p2.Rad * p2.center.Distance(new Point(0, 0))) return -1;
                return 0;
            });
        }
    }
}