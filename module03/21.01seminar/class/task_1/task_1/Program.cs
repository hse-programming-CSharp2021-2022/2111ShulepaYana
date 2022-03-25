using System;

namespace task_1
{
    public class NewStringValueEventArgs : EventArgs
    {
        public NewStringValueEventArgs(string str)
        {
            StringVal = str;
        }
        public string StringVal { get; }
    }

    public class UIString
    {
        string str = "Default text";
        public string Str
        {
            get { return str; }
            private set { str = value; }
        }
        public void NewStringValueHappenedHandler(object sender, NewStringValueEventArgs e)
        {
            str = e.StringVal;
        }
    }

    class ConsoleUI
    {
        public event EventHandler<NewStringValueEventArgs> NewStringValueHappened;
        UIString str = new UIString();

        public UIString Str
        {
            get { return str; }

            set { str = value; }
        }

        public void GetStringFromUI()
        {
            Console.Write("Введите новое значение строки: ");
            string str = Console.ReadLine();
            NewStringValueHappened?.Invoke(this, new NewStringValueEventArgs(str));
            RefreshUI();
        }

        public void CreateUI()
        {
            NewStringValueHappened += Str.NewStringValueHappenedHandler;
            RefreshUI();
        }

        public void RefreshUI()
        {
            Console.Clear();
            Console.WriteLine("Текст строки: " + Str.Str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI c = new ConsoleUI();
            c.CreateUI();
            do
            {
                c.GetStringFromUI();
                Console.WriteLine("Чтобы закончить эксперименты, нажмите ESC...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}