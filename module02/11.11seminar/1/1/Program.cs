using System;

namespace _1
{
    abstract class Animal
    {
        public string Nickname { get; protected set; }
        public int Age { get; protected set; }
        public Animal(string nickname, int age)
        {
            Nickname = nickname;
            Age = age;
        }
        public abstract string AnimalSound();
        public abstract string AnimalInfo();
        
    }
    class Dog : Animal
    {
        public string Breed { get; set; }
        public bool IsTrained { get; set; }
        public Dog(string nickname, int age, string breed, bool isTrained) : base(nickname, age)
        {
            Breed = breed;
            IsTrained = isTrained;
        }
        public override string AnimalSound() => "bark bark woof woof";
        public override string AnimalInfo() => $"Nickname: {Nickname}; Age: {Age}; Breed: {Breed}; Trained: {IsTrained}; Sound: {AnimalSound()}";
    }
    class Cow : Animal
    {
        public int Milk { get; set; }
        public Cow(string nickname, int age, int milk) : base(nickname, age)
        {
            Milk = milk;
        }
        public override string AnimalSound() => "moooooooooooo";
        public override string AnimalInfo() => $"Nickname: {Nickname}; Age: {Age}; milk: {Milk}; Sound: {AnimalSound()}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nicknameC = Console.ReadLine();
            string nicknameD = Console.ReadLine();
            int ageC = int.Parse(Console.ReadLine());
            int ageD = int.Parse(Console.ReadLine());
            string breed = Console.ReadLine();
            bool isTrained = bool.Parse(Console.ReadLine());
            int milk = int.Parse(Console.ReadLine());
            Cow cow = new Cow(nicknameC, ageC, milk);
            Dog dog = new Dog(nicknameD, ageD, breed, isTrained);
        }
    }
}
