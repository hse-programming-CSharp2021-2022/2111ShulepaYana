using System;
using System.IO;

namespace HW11_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            using (BinaryWriter writer = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                    writer.Write(random.Next(1, 101));
            }
        }
    }
}