using System;
using System.Collections.Generic;

namespace task_1
{
    public abstract class Animal
    {
        public abstract int Age { get; set; }
    }

    public interface IJumper
    {
        public void Jump();
    }

    public interface IRunner
    {
        public void Run();
    }

    public class Cockroach : Animal, IRunner
    {
        public override int Age { get; set; }
        public int Speed { get; set; }

        public Cockroach(int age, int speed)
        {
            Age = age;
            Speed = speed;
        }

        public void Run()
        {
            Console.WriteLine($"Скорость таракана: {Speed}");
        }
    }

    public class Kangaroo : Animal, IJumper
    {
        public override int Age { get; set; }
        public int JumpDistance { get; set; }

        public Kangaroo(int age, int jumpDistance)
        {
            Age = age;
            JumpDistance = jumpDistance;
        }

        public void Jump()
        {
            Console.WriteLine($"Прыжок Кенгуру: {JumpDistance}");
        }
    }

    public class Cheetah : Animal, IRunner, IJumper
    {
        public override int Age { get; set; }
        public int Speed { get; set; }
        public int JumpDistance { get; set; }

        public Cheetah(int age, int speed, int jumpDistance)
        {
            Age = age;
            Speed = speed;
            JumpDistance = jumpDistance;
        }

        public void Run()
        {
            Console.WriteLine($"Скорость Гепарда: {Speed}");
        }

        public void Jump()
        {
            Console.WriteLine($"Прыжок Гепарда: {JumpDistance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5]
            {
                new Cockroach(10, 150), new Cockroach(15, 180), new Kangaroo(10, 10), new Cheetah(5, 200, 8),
                new Cheetah(1, 50, 2)
            };
            List<IJumper> jumpers = new();
            List<IRunner> runners = new();
            foreach (var animal in animals)
            {
                if (animal is IJumper)
                    jumpers.Add(animal as IJumper);
                if (animal is IRunner)
                    runners.Add(animal as IRunner);
            }

            foreach (var el in jumpers)
                (el).Jump();
            foreach (var el in runners)
                (el).Run();
        }
    }
}