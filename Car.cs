public class Car : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; }
    public Car(string name, string color, string fuelType, int fuelTotal = 10) : base(name, color)
    {
        FuelType = fuelType;
        FuelTotal = fuelTotal;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"Refueling {Name} with some {FuelType}!!");
    }
}