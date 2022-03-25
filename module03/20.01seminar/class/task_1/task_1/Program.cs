using System;
namespace task_1
{
    delegate void SquareSizeChanged(double value);
    class Square    
    {
        public Square(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        public event SquareSizeChanged OnSizeChanged;
        public double X1       
        {
            get
            {
                return x1;
            }
            set => OnSizeChanged(Math.Abs(value - X2));
        }
        public double Y1        
        {
            get
            {
                return y1;
            }
            set => OnSizeChanged(Math.Abs(value - Y2));
        }
        public double X2        
        {
            get
            {
                return x2;
            }
            set => OnSizeChanged(Math.Abs(value - X1));
        }
        public double Y2        
        {
            get
            {
                return y2;
            }
            set => OnSizeChanged(Math.Abs(value - Y1));
        }
    }
    class Program    
    {
        static void Main(string[] args)
        {
            static void SquareConsoleInfo(double x) => Console.WriteLine(Math.Round(x,2));
            Console.WriteLine("Первая точка");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Вторая точка");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Square square = new(x1, y1, x2, y2);
            square.OnSizeChanged += SquareConsoleInfo;
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            for (int i = 0; i < n; i++)
            {
                double xChanged = double.Parse(Console.ReadLine());
                double yChanged = double.Parse(Console.ReadLine());
                square.X2 = xChanged;
                square.Y2 = yChanged;
            }
        }
    }
}