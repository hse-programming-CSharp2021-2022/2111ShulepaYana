using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();
            string finalNum;
            Change(in numberStr, out finalNum);
            Console.WriteLine(finalNum);
        }
        static void Change(in string numberStr, out string finalNum)
        {
            int number = int.Parse(numberStr);
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a0 = 0;
            while (number != 0)
            {
                int a = number % 10;
                number /= 10;
                switch (a)
                {
                    case 0:
                        a0 += 1;
                        break;
                    case 1:
                        a1 += 1;
                        break;
                    case 2:
                        a2 += 1;
                        break;
                    case 3:
                        a3 += 1;
                        break;
                    case 4:
                        a4 += 1;
                        break;
                    case 5:
                        a5 += 1;
                        break;
                    case 6:
                        a6 += 1;
                        break;
                    case 7:
                        a7 += 1;
                        break;
                    case 8:
                        a8 += 1;
                        break;
                    case 9:
                        a9 += 1;
                        break;
                }
            }
            finalNum = new String('9', a9) + new String('8', a8) + new String('7', a7) + new String('6', a6) +
                new String('5', a5) + new String('4', a4) + new String('3', a3) + new String('2', a2) +
                new String('1', a1) + new String('0', a0);
        }
    }
}
