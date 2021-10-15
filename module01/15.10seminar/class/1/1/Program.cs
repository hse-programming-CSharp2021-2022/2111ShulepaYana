using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        //string[] names = { "afsd", "fewgf", "2r3ef", "As32rfed", "fwefrf" };
        //List<string> str = new List<string>();
        //for (int i = 0; i < names.Length; i++)
        //{
        //    if (names[i].ToUpper().StartsWith("a"))
        //        str.Add(names[i]);
        //}
        //foreach (var i in str)
        //    Console.Write(i + " ");


        //var str2 = from s in names
        //           where s.ToUpper().StartsWith("A")
        //           // orderby s descending
        //           select s; //С отложенным выполнением.
        //foreach (var i in str2)
        //    Console.Write(i + " ");

        //var str3 = (from s in names
        //            where s.ToUpper().StartsWith("A")
        //            // orderby s descending
        //            select s).ToArray(); //Теперь неотложенное выполнение,
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(1, 10001);
        }
        foreach (var i in arr)
            Console.Write(i + " ");
        Console.WriteLine();

        var nw = from k in arr
                 where ((k % 3 == 0) && ((int)Math.Log10(k) + 1 == 2))
                 select k;
        foreach (var i in nw)
            Console.Write(i + " ");
        Console.WriteLine();

        var nw2 = from m in arr
                  where m.ToString().Reverse().SequenceEqual(m.ToString())
                  orderby m ascending
                  select m;
        foreach (var i in nw2)
            Console.Write(i + " ");
        Console.WriteLine();

        var nw4 = from d in arr
                  where ((int)Math.Log10(d) + 1 == 4)
                  select d;
        int sum = 0;
        foreach (var i in nw4)
            sum += i;
        Console.WriteLine(sum);



        string s = "Бык тупогуб, тупогубенький бычок";
        Regex regex = new Regex(@"туп\w*");
        var mathes = regex.Matches(s);
        foreach (Match m in mathes)
        {
            Console.WriteLine(m.Value);
        }
    }

}
