using System;

namespace test8
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int len = numStr.Length;
            int num = int.Parse(numStr);
            Console.WriteLine(Change(ref num, ref len));
        }

        public static int Change(ref int num, ref int len)
        {
            int newNum = 0;
            int k = 10;
            for (int i = 0; i < len; i++)
            {
                if ((i == 0) && (num % 10 == 0))
                {
                    num /= 10;
                    continue;
                }
                else
                {
                    newNum = newNum * k + num % 10;
                    num /= 10;
                }
            }
            return newNum;
        }
    }
}
