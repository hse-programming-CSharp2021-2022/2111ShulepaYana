using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
namespace Task01
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Pocket { get; set; } = string.Empty;
        public abstract void Receive(string present);
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name} получил(а) {Pocket} от Санты";
        }
    }
    class SnowMaiden : Person
    {
        public SnowMaiden(string name) : base(name) { }
        public string[] CreatePresents(int amount)
        {
            string[] presents = new string[amount];
            for (int i = 0; i < presents.Length; i++)
                presents[i] = CreatePresent();
            return presents;
        }
        public string CreatePresent()
        {
            Random rand = new Random();
            StringBuilder present = new StringBuilder();
            for (int i = 0; i < 3; i++)
                present.Append(((char)(rand.Next('A', 'Z' + 1))).ToString());
            present.Append(present.ToString()[1]);
            present.Append(present.ToString()[0]);
            return present.ToString();
        }

        public override void Receive(string present)
        {
            if (!Pocket.Equals(string.Empty))
                throw new ArgumentException($"{Name} уже получал(а) подарок");
            Pocket = present;
        }
    }
    class Santa : Person
    {
        public List<string> sack { get; set; } = new List<string>();
        public Santa(string name) : base(name) { }
        public void Request(SnowMaiden snowMaiden, int amount)
        {
            string[] presents = snowMaiden.CreatePresents(amount);
            for (int i = 0; i < amount; i++)
            {
                sack.Add(presents[i]);
            }
        }
        public void Give(Person person)
        {
            Random rand = new Random();
            if (sack.Count > 0)
            {
                int n = rand.Next(0, sack.Count);
                person.Receive(sack[n]);
                sack.RemoveAt(n);
            }
            else
            {
                throw new IndexOutOfRangeException("Подарки закончились...");
            }
        }
        public override void Receive(string present)
        {
            if (!Pocket.Equals(string.Empty))
                throw new ArgumentException($"{Name} уже получал(а) подарок");
            Pocket = present;
        }
    }
    class Child : Person
    {
        public string additionalPocket { get; set; } = string.Empty;
        public Child(string name) : base(name) {}
        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else if (additionalPocket.Equals(string.Empty))
                additionalPocket = present;
            else throw new ArgumentException($"{Name} уже получал(а) подарок");
        }
        public override string ToString()
        {
            if (additionalPocket.Equals(string.Empty))
                return $"{Name} получил(а) {Pocket} от Санты";
            else
            {
                return $"{Name} получил(а) {additionalPocket} от Санты";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Santa santa = new Santa("Santa");
            SnowMaiden maiden = new SnowMaiden("SnowMaiden");
            List<Person> people = new List<Person>();
            people.Add(santa);
            people.Add(maiden);
            for (int i = 1; i < 12; i++)
                people.Add(new Child($"Child{i}"));
            Random rand = new Random();
            while (people.Contains(santa))
            {
                if (people.Contains(maiden))
                    santa.Request(maiden, rand.Next(1, 5));
                try
                {
                    while (people.Count > 0)
                    {
                        int i = rand.Next(0, people.Count);
                        try
                        {
                            santa.Give(people[i]);
                            Console.WriteLine(people[i]);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            if (people[i] == santa)
                                break;
                            people.RemoveAt(i);
                        }
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    if (!people.Contains(maiden))
                        break;
                }

                if (people.Count == 1 && people.Contains(santa))
                    break;
            }
        }
    }
}