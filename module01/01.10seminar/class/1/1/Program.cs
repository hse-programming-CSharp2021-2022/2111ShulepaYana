using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double[] mas = new double[a];
            int[] masInt = new int[a];
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                mas[i] = rnd.NextDouble() * rnd.Next(-20, 21);
                Console.Write(mas[i] + " ");
                double c = mas[i];
                masInt[i] = (int)c;
                mas[i] -= masInt[i];
            }
            Array.Sort(mas);
            Array.Sort(masInt);
            Console.WriteLine();
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.ForEach(masInt, el => Console.Write(el + " "));
        }
    }
}
