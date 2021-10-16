using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            do
            {
                Console.WriteLine("Пожалуйста, введите латинскую строчную букву.");
                string chStr = Console.ReadLine();
                char.TryParse(chStr, out char ch);
                if (Shift(ref ch))
                {
                    Console.WriteLine("Новая буква: " + ch);
                    check = true;
                }
                else Console.WriteLine("Некорректный ввод");
            } while (check != true);
        }
        public static bool Shift(ref char ch)
        {
            if ((ch == '\0') || ((int)ch < 97) || ((int)ch > 122))
                return false;
            if ((int)ch < 119)
                ch = (char)((int)ch + 4);
            else ch = (char)((int)ch - 22);
            return true;
        }
    }
}
