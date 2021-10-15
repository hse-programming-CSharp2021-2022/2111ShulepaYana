using System;
namespace test7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            int a = int.Parse(a1);
            int b = int.Parse(b1);
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;

            }
        }
    }
}