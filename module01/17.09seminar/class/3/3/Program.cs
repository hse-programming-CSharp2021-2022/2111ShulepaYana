using System;
namespace test8
{
    class Program
    {

        static void Main(string[] args)
        {
            float sum1 = 1;
            float sum2 = 0;
            float a = 1;
            float b = 2;
            float c = 3;
            while (sum1 - sum2 != 0)
            {
                sum1 = sum2;
                sum2 = sum2 + 1 / (a * b * c);
                a += 1;
                b += 1;
                c += 1;
            }
            Console.WriteLine(sum2);

            double sum3 = 1;
            double sum4 = 0;
            double a1 = 1;
            double b1 = 2;
            double c1 = 3;
            while (sum3 - sum4 != 0)
            {
                sum3 = sum4;
                sum4 = sum4 + 1 / (a1 * b1 * c1);
                a1 += 1;
                b1 += 1;
                c1 += 1;
            }
            Console.WriteLine(sum4);

        }
    }
}