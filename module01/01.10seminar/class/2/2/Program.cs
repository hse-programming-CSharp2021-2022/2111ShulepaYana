using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] mas = new int[n][];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
                mas[i] = new int[rnd.Next(5, 16)];
            for (int i = 0; i < mas.Length; i++, Console.WriteLine())
                for (int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = rnd.Next(-10, 11);
                    Console.Write(mas[i][j] + " ");
                }
            for (int i = 0; i < mas.Length; i++)
            {
                Array.Sort(mas[i]);
                Array.Reverse(mas[i]);
            }
            Array.Sort(mas, Len);
            for (int i = 0; i < mas.Length; i++, Console.WriteLine())
                for (int j = 0; j < mas[i].Length; j++)
                    Console.Write(mas[i][j] + " ");
        }
        
        public static int Len(int[] x, int[] y)
        {
            if (x.Length > y.Length) return -1;
            if (x.Length < y.Length) return 1;
            return 0;
        }
    }
}
