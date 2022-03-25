using System;

namespace task1
{
    class Program
    {
        delegate int Cast(double x);
        static void Main(string[] args)
        {
            Cast cast1 = delegate(double x)
            {
                if ((int) x % 2 == 0)
                {
                    Console.WriteLine((int) x);
                    return (int) x;
                }
                else
                {
                    Console.WriteLine((int) x + 1);
                    return (int) x + 1;
                }
            };
            Cast cast2 = (double x) =>
            {
                string b = ((int) x).ToString();
                Console.WriteLine(b.Length);
                return b.Length;
            };
            cast1(21);
            cast2(21);
            cast1(1344);
            cast2(1344);
            cast1(17.43);
            cast2(17.43);

            Cast cast3 = cast1;
            cast3 += cast2;
            cast3(17.43);
            cast3.Invoke(17.43);

            cast3 -= cast2;
            cast3.Invoke(17.43);
            cast3 += cast2;
            Delegate.Remove(cast3, cast2);
            cast3.Invoke(17.43);
        }
    }
}