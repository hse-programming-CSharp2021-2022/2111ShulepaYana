using System;

namespace Dots
{
    public delegate void CoordChanged(Dot dot);
    public class Dot
    {
        public double X { get; set; }
        public double Y { get; set; }
        public event CoordChanged OnCoordChanged;
        Random rnd = new Random();
        public Dot(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void DotFlow()
        {
            for (int i = 0; i < 10; i++)
            {
                this.X = rnd.NextDouble() * 20 - 10;
                this.Y = rnd.NextDouble() * 20 - 10;
                if (X < 0 && Y < 0)
                {
                    OnCoordChanged?.Invoke(this);
                }
            }

        }
    }
}