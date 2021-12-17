using System;
using task04Lib_Shape;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int N1 = rand.Next(3, 6);
            int N2 = rand.Next(3, 6);
            int N3 = rand.Next(3, 6);
            Shape[] arr = new Shape[N1 + N2 + N3];
            for (int i = 0; i < N1; i++)
                arr[i] = new Circle(rand.Next(1, 11));
            for (int i = N1; i < N1 + N2; i++)
                arr[i] = new Cylinder(rand.Next(1, 11), rand.Next(1, 11));
            for (int i = N1 + N2; i < N1 + N2 + N3; i++)
                arr[i] = new Sphere(rand.Next(1, 11));
            for (int i = 0; i < N1 + N2 + N3; i++)
                Console.WriteLine(arr[i].Area());
            Array.Sort(arr, Sorting);
            for (int i = 0; i < N1 + N2 + N3; i++)
            {
                if (arr[i] is Circle)
                    Console.WriteLine($"Circle; Area: {arr[i].Area()}");
                if (arr[i] is Cylinder)
                    Console.WriteLine($"Cylinder; Area: {arr[i].Area()}");
                if (arr[i] is Sphere)
                    Console.WriteLine($"Sphere; Area: {arr[i].Area()}");
            }
            
        }

        public static int Sorting(Shape first, Shape second)
        {
            if (first is Circle && second is Circle)
                return 0;
            if (first is Cylinder && second is Cylinder)
                return 0;
            if (first is Sphere && second is Sphere)
                return 0;
            if (first is Cylinder && second is Circle)
                return 1;
            if (first is Sphere && second is Circle)
                return 1;
            if (first is Sphere && second is Cylinder)
                return 1;
            return -1;
        }
    }
}