using System;

namespace _1
{
    class MyComplex
    {
        public double re, im;
        public MyComplex(double xre, double xim)
        { re = xre; im = xim; }
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }
        public double Mod() { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        public static MyComplex operator +(MyComplex one, MyComplex two)
        {
            double n = one.re + two.re;
            double i = one.im + two.im;
            return new MyComplex(n, i);
        }
        public static MyComplex operator -(MyComplex one, MyComplex two)
        {
            double n = one.re - two.re;
            double i = one.im - two.im;
            return new MyComplex(n, i);
        }
        public static MyComplex operator *(MyComplex one, MyComplex two)
        {
            double n = one.re * two.re - one.im * two.im;
            double i = one.im * two.re + one.re * two.im;
            return new MyComplex(n, i);
        }
        public static MyComplex operator /(MyComplex one, MyComplex two)
        {
            double n = (one.re * two.re + two.im * one.im) / (two.re * two.re + two.im * two.im);
            double i = (one.im * two.re - one.re * two.im) / (two.re * two.re + two.im * two.im);
            return new MyComplex(n, i);
        }
        public override string ToString()
        {
            return "real = " + this.re + "; image = " + this.im + ";";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex cp1 = new MyComplex(2, 4);
            MyComplex cp2 = new MyComplex(1, 3);
            Console.WriteLine(cp1);
            Console.WriteLine(cp2);
            Console.WriteLine(cp1 + cp2);
            Console.WriteLine(cp1 - cp2);
            Console.WriteLine(cp1 * cp2);
            Console.WriteLine(cp1 / cp2);
        }
    }
}
