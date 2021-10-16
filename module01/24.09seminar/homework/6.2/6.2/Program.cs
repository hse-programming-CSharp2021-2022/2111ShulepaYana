using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
            Print(arr);
            arr = Array.FindAll(arr, IsDivTwo);
            Console.WriteLine();
            Print(arr);
        }
        static void Print(int[] arr)
        {
            foreach (int el in arr)
                Console.Write(el + " ");
        }
        static bool IsDivTwo(int a)
        {
            return (a % 2 != 0);
        }
    }
}
