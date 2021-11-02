using System;
using System.Linq;
using System.Collections.Generic;

namespace _1
{
    class Polygon
    {
        double Radius { get; set; }
        int Num { get; set; }
        public Polygon(int num = 0, double radius = 0)
        {
            Num = num; Radius = radius;
        }
        public double Perimeter
        {
            get
            {
                return Num * 2 * Radius / Math.Cos(Math.PI/Num) * Math.Sin(Math.PI/Num);
            }
        }
        public double Area
        {
            get
            {
                return 0.5 * Perimeter * Radius;
            }
        }
        public override string ToString()
        {
            return "Количество сторон: " + Num + "; Радиус: " + Radius + ";";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите количество элементов");
            //int n = int.Parse(Console.ReadLine());
            //Polygon[] arr = new Polygon[n];
            List<Polygon> list = new List<Polygon>();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Введите сначала количество сторон, а потом радиус " + (i + 1) + "-го многоугольника");
            //    arr[i] = new Polygon(int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            //}
            int n = 1;
            double r = 1;
            int i = 0;
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Введите сначала количество сторон, а потом радиус " + (i + 1) + "-го многоугольника");
                n = int.Parse(Console.ReadLine());
                r = double.Parse(Console.ReadLine());
                if ((n == 0) && (r == 0))
                    break;
                list.Add(new Polygon(n, r));
                i++;
                Console.WriteLine("Все введенные вами многоугольники:");
                for (int j = 0; j < list.Count; j++)
                    Console.WriteLine(list[j]);
            }
            //double[] areas = new double[n];
            //for (int i = 0; i < n; i++)
            //{
            //    areas[i] = arr[i].Area;
            //}
            double[] areas = new double[list.Count];
            for (int j = 0; j < areas.Length; j++)
            {
                areas[j] = list[j].Area;
            }
            int max = Array.IndexOf(areas, areas.Max());
            int min = Array.IndexOf(areas, areas.Min());
            Console.WriteLine("Полученные площади:");
            for (int j = 0; j < areas.Length; j++)
            {
                if (j == min)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (j == max)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(areas[j]);
                Console.ResetColor();
            }
        }
    }
}
