using System;

namespace HW7_person
{
    struct Person : IComparable<Person>
    {
        string name;
        string lastName;
        int age;

        public Person(string name, string lastName, string age)
        {
            this.name = name;
            this.lastName = lastName;
            if (int.Parse(age) < 0)
                throw new ArgumentOutOfRangeException();
            this.age = int.Parse(age);
        }

        public int CompareTo(Person other)
        {
            return age.CompareTo(other.age);
        }

        public override string ToString()
        {
            return $"{name} {lastName}; Age: {age}";
        }
    }
    class Program
    {
        private static string line = "abcdefghijklmnopqrstuvwxyz";
        static void Main(string[] args)
        {
            Random rand = new Random();
            Person[] characters = new Person[5];
            for (int i = 0; i < 5; i++)
            {
                string name = "", lastName = "";
                for (int j = 0; j < 5; j++)
                {
                    name += line[rand.Next(0, 26)];
                    lastName += line[rand.Next(0, 26)];
                }
                characters[i] = new Person(name, lastName, rand.Next(1, 101).ToString());
            }
            Array.ForEach(characters, x => Console.WriteLine(x));
            Console.WriteLine();
            Array.Sort(characters);
            Array.ForEach(characters, x => Console.WriteLine(x));
        }
    }
}