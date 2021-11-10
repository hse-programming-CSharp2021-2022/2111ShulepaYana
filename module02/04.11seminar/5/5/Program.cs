using System;
using System.Text;

namespace _5
{
    class VideoFile
    {
        public string string_name { get; set; }
        public int int_duration { get; set; }
        public int int_quality { get; set; }
        public VideoFile(string name, int duration, int quality)
        {
            string_name = name;
            int_duration = duration;
            int_quality = quality;
        }
        public VideoFile()
        {
            string_name = "";
            int_duration = 0;
            int_quality = 0;
        }
        public int Size
        {
            get
            {
                return (int_quality * int_duration);
            }
        }
        public override string ToString()
        {
            return "Название: " + string_name + "; Длительность: " + int_duration + "; Качество: " + int_quality + ";";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                VideoFile first = new VideoFile("first", rnd.Next(60, 361), rnd.Next(100, 1001));
                Console.WriteLine("\nОтдельный файл: " + first);
                int N = rnd.Next(5, 16);
                Console.WriteLine("Количество элементов: " + N);
                Console.WriteLine("Ваш массив:");
                VideoFile[] arr = new VideoFile[N];
                for (int i = 0; i < N; i++)
                {
                    arr[i] = new VideoFile();
                    arr[i].int_duration = rnd.Next(60, 361);
                    arr[i].int_quality = rnd.Next(100, 1001);
                    int numChars = rnd.Next(2, 10);
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j <= numChars; j++)
                    {
                        char letter = (char)rnd.Next(97, 123);
                        sb.Append(letter);
                    }
                    arr[i].string_name = sb.ToString();
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("Файлы, размер которых больше:");
                for (int i = 0; i < N; i++)
                {
                    if (arr[i].Size > first.Size)
                        Console.WriteLine(arr[i]);
                }
                Console.WriteLine("Для остановки программы нажмите escape. Для продолжения нажмите любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
