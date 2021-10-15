using System;
namespace test7
{
    class Program
    {
        public static void Grades(int gradeFin, string gradeFin2)
        {

            if ((gradeFin == 1) || (gradeFin == 2) || (gradeFin == 3))
                gradeFin2 = "неудовлетворительно";
            else if ((gradeFin == 4) || (gradeFin == 5))
                gradeFin2 = "удовлетворительно";
            else if ((gradeFin == 6) || (gradeFin == 7))
                gradeFin2 = "хорошо";
            else if ((gradeFin == 8) || (gradeFin == 9) || (gradeFin == 10))
                gradeFin2 = "отлично";
            Console.WriteLine(gradeFin2);
        }
        static void Main(string[] args)
        {
            string grade = Console.ReadLine();
            int gradeFin = int.Parse(grade);
            string gradeFin2 = "";
            Grades(gradeFin, gradeFin2);
            Console.WriteLine(gradeFin2);
        }
    }
}