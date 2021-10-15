using System;
namespace test8
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = Console.ReadLine();
            int m = 0;
            int min = 10;
            int c = 0;
            int a = int.Parse(strA);
            while (a > 0)
            {
                c = a % 10;
                if (c < min)
                    min = c;
                if (c > m)
                    m = c;
                a = a / 10;
            }
            Console.WriteLine($"{m} {min}");
        }
    }
}