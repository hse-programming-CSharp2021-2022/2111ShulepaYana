using System;
public partial class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[] mas = new char[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            mas[i] = (char)rnd.Next('A', 'Z' + 1);
        }
        Print(mas);
        char[] mas2 = new char[n];
        mas2 = mas;
        Array.Sort(mas2);
        Print(mas2);
        Array.Reverse(mas2);
        Print(mas2);
    }
    public static void Print(char[] mas)
    {
        foreach (var el in mas)
            Console.Write(el + " ");
        Console.WriteLine();
    }
}