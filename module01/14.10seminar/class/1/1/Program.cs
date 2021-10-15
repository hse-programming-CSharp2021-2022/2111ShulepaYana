using System;
using System.IO;
using System.Text;
namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";
            var rnd = new Random();
            StreamWriter sw = new StreamWriter(path);
            if (File.Exists(path))
            {
                Console.WriteLine("Сколько строчек записать в файл?");
                int num = int.Parse(Console.ReadLine());
                string[] array = new string[5];
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array[j] = (rnd.Next(10, 100)).ToString();
                        sw.Write(array[j] + " ");
                        if (j == 4)
                        {
                            Array.Clear(array, 0, 5);
                            if (i != num - 1)
                                sw.Write(Environment.NewLine);
                        }
                    }
                }
                sw.Close();
            }
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                TwoArrays(ref arr, out int[] arr1, out int[] arr2);
                Console.WriteLine();
                foreach (int i in arr1)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                foreach (int i in arr2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                int.TryParse(str[i], out arr[i]);
            }
            return arr;
        }
        public static void TwoArrays(ref int[] arr, out int[] arr1, out int[] arr2)
        {
            arr1 = new int[arr.Length];
            arr2 = new int[arr.Length];
            int j = 0, k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr1[j] = arr[i];
                    arr[i] = 0;
                    j++;
                }
                else
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }
            Array.Resize(ref arr1, Array.IndexOf(arr1, 0));
            Array.Resize(ref arr2, Array.IndexOf(arr2, 0));
        }
    }
}