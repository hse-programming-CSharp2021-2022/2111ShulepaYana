using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int a1 = a % 100;
            int b1 = b % 100;
            int c1 = c % 100;
            int min = Math.Min(a1, Math.Min(b1, c1));
            if (min == a1) Console.WriteLine(a);
            else if (min == b1) Console.WriteLine(b);
            else if (min == c1) Console.WriteLine(c);
        }
    }
}
