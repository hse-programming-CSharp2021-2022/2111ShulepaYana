using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                mas[i] = int.Parse(a);
            }
            /*Random rand = new Random();
            for(int i = 0; i < mas.Length; i++)
                mas[i] = rand.Next(1, 10); */
            Change(in mas, ref n);
        }
        static void Change(in int[] mas, ref int n)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if ((mas[i] + mas[i + 1]) % 3 == 0)
                {
                    mas[i] = mas[i] * mas[i + 1];
                    --n;
                    for (int j = i + 1; j < n; j++)
                        mas[j] = mas[j + 1];
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(mas[i] + " ");
        }
    }
}
