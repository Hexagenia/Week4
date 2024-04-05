using System;

namespace Inheritance
{
    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";
        }

        // parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // first derived class
    class Horse : Animal
    {
        public string color;
        public int height;
        public int weight;

        // default constructor
        public Horse()
        {
            color = "";
            height = 0;
            weight = 0;
        }

        // parameterized constructor
        public Horse(string name, string color, int height, int weight) : base(name)
        {
            this.color = color;
            this.height = height;
            this.weight = weight;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Horse Information...");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}\n");
        }
    }

    // second derived class
    class Cat : Animal
    {
        public int age;
        public double height;
        public int weight;

        // default constructor
        public Cat()
        {
            age = 0;
            height = 0.0;
            weight = 0;
        }

        // parameterized constructor
        public Cat(string name, int age, double height, int weight) : base(name)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Cat Information...");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal("Joey");
            myPet.DisplayInfo();

            // derived class objects (the horses and cats)
            Horse horse1 = new Horse("Henry the Horse", "Light Brown", 6, 600);
            horse1.DisplayInfo();

            Cat cat1 = new Cat("Parmida the Cat", 2, 5.4, 34);
            cat1.DisplayInfo();

            Horse horse2 = new Horse("Thunder the Horse", "Grey", 5, 453);
            horse2.DisplayInfo();

            Cat cat2 = new Cat("Colin the Cat", 3, 5.6, 43);
            cat2.DisplayInfo();
        }
    }
}