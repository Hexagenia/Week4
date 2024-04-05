using System;

// Base Class
class NASCARTeam
{
    // Private fields
    private string teamName;
    private string manufacturer;
    private int numberOfMembers;

    // Default constructor
    public NASCARTeam()
    {
        teamName = "";
        manufacturer = "";
        numberOfMembers = 0;
    }

    // Parameterized constructor
    public NASCARTeam(string teamName, string manufacturer, int numberOfMembers)
    {
        this.teamName = teamName;
        this.manufacturer = manufacturer;
        this.numberOfMembers = numberOfMembers;
    }

    // Getters and setters
    public string GetTeamName()
    {
        return teamName;
    }

    public void SetTeamName(string teamName)
    {
        this.teamName = teamName;
    }

    public string GetManufacturer()
    {
        return manufacturer;
    }

    public void SetManufacturer(string manufacturer)
    {
        this.manufacturer = manufacturer;
    }

    public int GetNumberOfMembers()
    {
        return numberOfMembers;
    }

    public void SetNumberOfMembers(int numberOfMembers)
    {
        this.numberOfMembers = numberOfMembers;
    }

    
    public virtual void AddOrChange()
    {
        Console.WriteLine("Base class method: Add or Change");
    }

    public virtual void Display()
    {
        Console.WriteLine($"Team Name: {teamName}, Manufacturer: {manufacturer}, Number of Members: {numberOfMembers}");
    }
}

// Derived Class
class NASCARDriver : NASCARTeam
{
    // Private fields
    private string driverName;
    private int carNumber;

    // Default constructor
    public NASCARDriver() : base()
    {
        driverName = "";
        carNumber = 0;
    }

    // Parameterized constructor
    public NASCARDriver(string teamName, string manufacturer, int numberOfMembers, string driverName, int carNumber) : base(teamName, manufacturer, numberOfMembers)
    {
        this.driverName = driverName;
        this.carNumber = carNumber;
    }

    // Getters and setters
    public string GetDriverName()
    {
        return driverName;
    }

    public void SetDriverName(string driverName)
    {
        this.driverName = driverName;
    }

    public int GetCarNumber()
    {
        return carNumber;
    }

    public void SetCarNumber(int carNumber)
    {
        this.carNumber = carNumber;
    }

    // Overriding base class methods
    public override void AddOrChange()
    {
        base.AddOrChange();
        Console.WriteLine("Derived class method: Add or Change");
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Driver Name: {driverName}, Car Number: {carNumber}");
    }
}

class PrivateMultipleObjects
{
    static void Main(string[] args)
    {
        // Array of base class objects
        NASCARTeam[] teams = new NASCARTeam[3];

        // Array of derived class objects
        NASCARDriver[] drivers = new NASCARDriver[3];

        // Fill arrays
        for (int i = 0; i < 3; i++)
        {
            string teamName = $"Team {i + 1}";
            string manufacturer = i == 0 ? "Toyota" : (i == 1 ? "Chevrolet" : "Ford");
            int numberOfMembers = i + 10;

            teams[i] = new NASCARTeam(teamName, manufacturer, numberOfMembers);

            string driverName = $"Driver {i + 1}";
            int carNumber = 10 + i;

            drivers[i] = new NASCARDriver(teamName, manufacturer, numberOfMembers, driverName, carNumber);
        }

        // Show base class objects
        Console.WriteLine("NASCAR Teams:");
        foreach (NASCARTeam team in teams)
        {
            team.Display();
        }

        // Showing derived class objects
        Console.WriteLine("\nNASCAR Drivers:");
        foreach (NASCARDriver driver in drivers)
        {
            driver.Display();
        }
    }
}