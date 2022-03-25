using System;

namespace HW5_functions
{
    interface IFunction
    {
        double Function(double x);
    }

    class F : IFunction
    {
        public Calculate calculate;
        public F(Calculate calc)
        {
            calculate = calc;
        }
        public double Function(double x)
        {
            return calculate(x);
        }
    }

    class G
    {
        public F f1;
        public F f2;
        public G(F a, F b)
        {
            f1 = a;
            f2 = b;
        }
        public double GF(double x0)
        {
            return f1.Function(f2.Function(x0));
        }
    }
    public delegate double Calculate(double x);
    class Program
    {
        static void Main(string[] args)
        {
            F f1 = new F((x) => x * x - 4);
            F f2 = new F((x) => Math.Sin(x));
            G g = new G(f1, f2);
            for (double i = 0; i <= Math.PI; i += Math.PI / 16)
            {
                Console.WriteLine($"{g.GF(i):F4}");
            }
        }
    }
}