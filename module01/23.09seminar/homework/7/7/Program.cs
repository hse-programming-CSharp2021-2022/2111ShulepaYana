using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Counting(a, b, out int nok, out int nod);
            Console.WriteLine(nod);
            Console.WriteLine(nok);
        }
        static void Counting(int a, int b, out int nok, out int nod)
        {
            nok = 0; nod = 0;
            for (int i = 1; i <= Math.Min(a,b); i++)
            {
                if ((a % i == 0) && (b % i == 0))
                    nod = i;
            }
            nok = a * b / nod;
        }
    }
}
