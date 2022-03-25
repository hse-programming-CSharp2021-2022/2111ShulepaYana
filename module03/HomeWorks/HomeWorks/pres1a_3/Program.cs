using System;

namespace pres1a_3
{
    public delegate double DelegateConvertTemperature(double temp);

    class TemperstureConvertImp
    {
        public double FarToCel(double temp)
        {
            return (double) 5 / 9 * (temp - 32);
        }
        public double CelToFar(double temp)
        {
            return (double) 9 / 5 * temp + 32;
        }
    }

    static class StaticTempConverters
    {
        public static double CelToKel(double temp)
        {
            Console.WriteLine("Kельвины");
            return temp + 273.15;
        }
        public static double CelToRan(double temp)
        {
            Console.WriteLine("Ранкины");
            return (temp + 273.15) * 9 / 5;
        }
        public static double CelToReo(double temp)
        {
            Console.WriteLine("Реомюры");
            return temp * 4 / 5;
        }
        public static double KelToCel(double temp)
        {
            return temp - 273.15;
        }
        public static double RanToCel(double temp)
        {
            return (temp - 491.67) * 5 / 9;
        }
        public static double ReoToCel(double temp)
        {
            return temp * 5 / 4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperstureConvertImp cl = new TemperstureConvertImp();
            DelegateConvertTemperature del1 = cl.FarToCel;
            DelegateConvertTemperature del2 = cl.CelToFar;
            Console.WriteLine(del1(20));
            Console.WriteLine(del2(20));

            DelegateConvertTemperature[] array = new DelegateConvertTemperature[2];
            array[0] = StaticTempConverters.CelToKel;
            array[0] += StaticTempConverters.CelToRan;
            array[0] += StaticTempConverters.CelToReo;
            array[1] = StaticTempConverters.KelToCel;
            array[1] += StaticTempConverters.RanToCel;
            array[1] += StaticTempConverters.ReoToCel;

            double cel = double.Parse(Console.ReadLine());
            foreach (var el in array[0].GetInvocationList())
            {
                Console.WriteLine(el.DynamicInvoke(cel));
            }
        }
    }
}