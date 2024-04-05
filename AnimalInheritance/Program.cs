using System;

// Base Class
class Animal
{
    private string name; 
    protected string type; 
    public string color; 

    public void setName(string name)
    {
        this.name = name;
    }

    public virtual string getName()
    {
        return this.name;
    }

    public void setType(string type)
    {
        this.type = type;
    }

    public virtual string getType()
    {
        return this.type;
    }
}

// Derived Class
class Cat : Animal
{
    private string breed; // private field
    public int height; // public field
    public int weight; // public field

    public void setBreed(string breed)
    {
        this.breed = breed;
    }

    public string getBreed()
    {
        return this.breed;
    }

    // Override base class methods
    public override string getName()
    {
        return base.getName();
    }

    public override string getType()
    {
        return base.getType();
    }
}

class AnimalInheritance
{
    static void Main(string[] args)
    {
        // Create an object from the base class
        Animal baseAnimal = new Animal();
        baseAnimal.setName("Ali");
        baseAnimal.setType("Dog");
        baseAnimal.color = "Liver";

        // Display base class data
            Console.WriteLine("Animal Information");
            Console.WriteLine("Name= " + baseAnimal.getName());
            Console.WriteLine("Type= " + baseAnimal.getType());
            Console.WriteLine("Color= " + baseAnimal.color);
            Console.WriteLine();

        // object from derived class
        Cat cat = new Cat();
        cat.setName("Helia");
        cat.setType("Cat");
        cat.color = "Black";
        cat.setBreed("Persian");
        cat.height = 9;
        cat.weight = 12;

        // derived class data output
            Console.WriteLine("Cat Information");
            Console.WriteLine("Name= " + cat.getName());
            Console.WriteLine("Type= " + cat.getType());
            Console.WriteLine("Color= " + cat.color);
            Console.WriteLine("Breed= " + cat.getBreed());
            Console.WriteLine("Height= " + cat.height);
            Console.WriteLine("Weight= " + cat.weight);
    }
}