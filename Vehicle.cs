// See https://aka.ms/new-console-template for more information

public abstract class Vehicle
{
    public string Name {get;set;}
    int Capacity {get;set;}
    string Color {get;set;}
    bool Engine {get;set;}
    int Milage = 0;

    public Vehicle(string name, string color)
    {
        Name = name;
        Color = color;
        Engine = true;
        Capacity = 5;
    }

    public Vehicle(string name, int capacity, string color, bool engine)
    {
        Name = name;
        Capacity = capacity;
        Color = color;
        Engine = engine;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Capacity: {Capacity}, Color: {Color}, Engine: {Engine}, Milage: {Milage}");
    }

    public void Travel(int miles)
    {
        Milage +=  miles;
        Console.WriteLine($"Your {Name} has traveled {miles}");
    }
}

