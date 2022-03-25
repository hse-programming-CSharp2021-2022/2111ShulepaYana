using System;

namespace pres1b_6
{
    class Plant
    {
        private double growth;
        private double photosensitivity;
        private double frostresistance;
        public double Growth { get; set; }
        public double PhotoSensitivity
        {
            get
            {
                return photosensitivity;
            }
            set
            {
                if (!(value >= 0 && value <= 100)) 
                    throw new ArgumentException();
                photosensitivity = value;
            }
        }
        public double FrostResistance
        {
            get
            {
                return frostresistance;
            }
            set
            {
                if (!(value >= 0 && value <= 100))
                    throw new ArgumentException();
                frostresistance = value;
            }
        }

        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            Growth = growth;
            PhotoSensitivity = photosensitivity;
            FrostResistance = frostresistance;
        }

        public override string ToString()
        {
            return $"growth: {Growth}, photosensitivity: {PhotoSensitivity}, frostresistance: {FrostResistance}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Plant[] arr = new Plant[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                double gr = 100 - rnd.NextDouble() * 75;
                double ph = rnd.NextDouble() * 100;
                double fr = rnd.NextDouble() * 80;
                arr[i] = new Plant(gr, ph, fr);
            }

            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(arr, delegate(Plant a, Plant b)
                {
                    if (a.Growth < b.Growth) return 1;
                    if (a.Growth > b.Growth) return -1;
                    return 0;
                }
            );
            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(arr, (a, b) =>
                {
                    if (a.FrostResistance > b.FrostResistance) return 1;
                    if (a.FrostResistance < b.FrostResistance) return -1;
                    return 0;
                }
            );
            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(arr, ComparePlants);
            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine();
            Array.ConvertAll(arr, (el) =>
            {
                if ((int)el.FrostResistance % 2 == 0)
                {
                    el.FrostResistance /= 3;
                }
                else
                {
                    el.FrostResistance /= 2;
                }
                return el;
            });
            Array.ForEach(arr, Console.WriteLine);
        }

        public static int ComparePlants(Plant a, Plant b)
        {
            if (a.PhotoSensitivity % 2 != 0 & b.PhotoSensitivity % 2 == 0) return 1;
            if (a.PhotoSensitivity % 2 - b.PhotoSensitivity % 2 < 0.0001) return 0;
            return -1;
        }
    }
}