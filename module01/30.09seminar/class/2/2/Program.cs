using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[99];
            Random rnd = new Random();
            int n = rnd.Next(1, 101);
            int j = 1;
            for (int i = 0; i < 99; i++)
            {
                if (j == n)
                    j++;
                arr[i] = j;
                j++;
            }
            int s = 0;
            foreach (int el in arr)
                s += el;
            Console.WriteLine(100 * (1 + 100) / 2 - s);
        }
    }
}
