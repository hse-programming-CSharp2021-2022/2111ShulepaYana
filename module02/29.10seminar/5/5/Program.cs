using System;

namespace _5
{
    class ConsolePlate
    {
        char _plateChar = 'A';
        ConsoleColor _plateColor = ConsoleColor.White;
        ConsoleColor _plateBackColor = ConsoleColor.Black;
        public char PlateChar
        {
            get { return _plateChar; }
            set
            {
                if (value > 64 || value < 91)
                    _plateChar = value;
                else
                    _plateChar = 'A';
            }
        }
        public ConsoleColor PlateColor
        {
            get { return _plateColor; }
            set { _plateColor = value; }
        }
        public ConsoleColor PlateBackColor
        {
            get { return _plateBackColor; }
            set
            {
                if (value == _plateColor)
                {
                    if (_plateColor != ConsoleColor.Black)
                        _plateBackColor = ConsoleColor.Black;
                    else
                        _plateBackColor = ConsoleColor.White;
                }
                else _plateBackColor = value;
            }
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor plateBackColor)
        {
            PlateChar = plateChar;
            PlateColor = plateColor;
            PlateBackColor = plateBackColor;
        }
        //char _plateChar = '+';
        //ConsoleColor _plateColor = ConsoleColor.White;
        //public char PlateChar
        //{
        //    get { return _plateChar; }
        //    set 
        //    {
        //        if (value > 31)
        //            _plateChar = value;
        //        else
        //            _plateChar = '+';
        //    }
        //}
        //public ConsoleColor PlateColor
        //{
        //    get { return _plateColor; }
        //    set { _plateColor = value; }
        //}
        //public ConsolePlate()
        //{
        //    _plateChar = '+';
        //}
        //public ConsolePlate(char plateChar, ConsoleColor plateColor)
        //{
        //    PlateChar = plateChar;
        //    PlateColor = plateColor;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate x = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate o = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            Console.WriteLine("Введите размер сетки");
            int N = int.Parse(Console.ReadLine());
            ConsolePlate[,] arr = new ConsolePlate[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0)
                        arr[i, j] = x;
                    else
                        arr[i, j] = o;
                }
            }
            for (int i = 0; i < N; i++, Console.WriteLine())
                for (int j = 0; j < N; j++)
                {
                    Console.ForegroundColor = arr[i, j].PlateColor;
                    Console.BackgroundColor = arr[i, j].PlateBackColor;
                    Console.Write(arr[i, j].PlateChar);
                }
            Console.ResetColor();
            //ConsolePlate[] arr =
            //{
            //    new ConsolePlate('a', ConsoleColor.Red),
            //    new ConsolePlate('+', ConsoleColor.Cyan),
            //    new ConsolePlate(),
            //    new ConsolePlate('M', ConsoleColor.Yellow),
            //    new ConsolePlate((char)30, ConsoleColor.DarkGreen),
            //    new ConsolePlate('=', ConsoleColor.Blue)
            //};
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.ForegroundColor = arr[i].PlateColor;
            //    Console.WriteLine(arr[i].PlateChar);
            //    Console.ResetColor();
            //}
        }
    }
}
