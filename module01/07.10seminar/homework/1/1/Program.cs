using System;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Let it be; All you need is Love; Dizzy Miss Lizzy";
            string[] arr = str.Split(";");
            for (int i = 0; i < arr.Length; i++)
            {
                string[] mas = arr[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                StringBuilder phrase = new StringBuilder();
                string letters = "aeiouy";
                for (int j = 0; j < mas.Length; j++)
                {
                    StringBuilder word = new StringBuilder();
                    for (int k = 0; k < mas[j].Length; k++)
                    {
                        if ((k == 0) && letters.Contains(char.ToLower(mas[j][k])))
                        {
                            word.Append(char.ToUpper(mas[j][k]));
                            break;
                        }
                        if ((k == 0) && !letters.Contains(char.ToLower(mas[j][k])))
                        {
                            word.Append(char.ToUpper(mas[j][k]));
                            continue;
                        }
                        if ((k != 0) && letters.Contains(char.ToLower(mas[j][k])))
                        {
                            word.Append(mas[j][k]);
                            break;
                        }
                        if ((k != 0) && !letters.Contains(char.ToLower(mas[j][k])))
                        {
                            word.Append(mas[j][k]);
                            continue;
                        }
                    }
                    phrase.Append(word.ToString());
                }
                Console.WriteLine(phrase.ToString());
            }
        }
    }
}
