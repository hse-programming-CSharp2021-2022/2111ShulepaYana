using System;
namespace Семинары
{
    class Program
    {
        static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            while (number != 0)
            {
                sumEven += number % 10;
                number = number / 10;
                sumOdd += number % 10;
                number = number / 10;
            }
            Console.WriteLine(sumEven);
            Console.WriteLine(sumOdd);
        }
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();
            uint number = uint.Parse(numberStr);
            Sums(number, out uint sumEven, out uint sumOdd);
        }
    }
}