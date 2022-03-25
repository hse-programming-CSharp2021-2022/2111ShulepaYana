using System;
using System.Collections.Generic;
using System.Linq;

namespace HW14_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(-1000, 1001));
            }
            list.ForEach(Console.WriteLine);
            Console.WriteLine();
            
            var list1 = list.Select(n => n * n).ToList();
            list1.ForEach(Console.WriteLine);
            Console.WriteLine();
            
            var list2 = list.Where(n => n > 0 && n.ToString().Length == 2).ToList();
            list2.ForEach(Console.WriteLine);
            Console.WriteLine();
            
            var list3 = list.Where(n => n % 2 == 0).OrderByDescending(n => n).ToList();
            list3.ForEach(Console.WriteLine);
            Console.WriteLine();
            
            var list4 = list.GroupBy(n => n.ToString().Length).ToList();
            list4.ForEach(x => x.ToList().ForEach(Console.WriteLine));
            Console.WriteLine();
        }
    }
}