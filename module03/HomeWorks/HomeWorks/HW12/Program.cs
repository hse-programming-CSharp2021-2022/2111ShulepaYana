using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace HW12
{
    [Serializable]
    class Human
    {
        public string Name { get; set;  }
        public Human(string name)
        {
            Name = name;
        }
    }
    [Serializable]
    class Professor : Human
    {
        public Professor(string name) : base(name) { }
    }
    [Serializable]
    class Departament
    {
        public string Name { get; set; }
        public List<Human> list { get; set; } = new List<Human>();

        public Departament(string name)
        {
            Name = name;
            Random rnd = new Random();
            List<Human> humans = new List<Human>();
            for (int i = 0; i < 10; i++)
            {
                var human = new Human("George");
                list.Add(human);
            }
        }
    }
    [Serializable]
    class University
    {
        public string Name { get; set; }
        public List<Departament> list { get; set; }

        public University(List<Departament> dep, string name)
        {
            Name = name;
            list = dep.ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            University[] un = new University[3];
            List<Departament> list = new List<Departament>();
            list.Add(new Departament("first"));
            list.Add(new Departament("second"));
            list.Add(new Departament("third"));
            un[0] = new University(list, "first");
            un[1] = new University(list, "second");
            un[2] = new University(list, "third");
            
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream("binary.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, un);
            }
            
            using (FileStream file = new FileStream("binary.bin", FileMode.OpenOrCreate))
            {
                List<University> binUn = (List<University>)formatter.Deserialize(file);
                foreach (var el in binUn)
                {
                    Console.WriteLine(el);
                }
                Console.WriteLine();
            }
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<University>));
            using (FileStream file = new FileStream("xmlser.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(file, un);
            }
            
            using (FileStream file = new FileStream("xmlser.xml", FileMode.Open))
            {
                var xmlUn = (List<University>)xmlSerializer.Deserialize(file);
                foreach (var el in xmlUn)
                {
                    Console.WriteLine(el);
                }
                Console.WriteLine();
            }
            
            var json  = JsonSerializer.Serialize(un.ToList());
            File.WriteAllText("jsonser.json", json);
            var deserUn = JsonSerializer.Deserialize<List<University>>(json);
            foreach (var el in deserUn)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
    }
}