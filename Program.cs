// See https://aka.ms/new-console-template for more information
/*
1.Create an instance of each child (car, horse, bicycle)
2.Try to create an instance of Vehicle. Make a comment on what happened.
3.Create a List of Vehicles and put all your instances inside of it (notice you can still make Lists of type Vehicle!)
4.Create a List of type INeedFuel, but do not add anything to it yet.
5.Loop through the List of Vehicles, and if an item has the INeedFuel interface applied, add it to the INeedFuel List. This should be done using coding logic. How can we identify that something has a specific interface applied to it? (Hint: you can find the answer on the page on Polymorphism.)
6.Take your finished INeedFuel List, loop through it, and give each item 10 units of fuel (what exactly 10 stands for here isn't the important part).
7.Finally, loop through the List again and print out the Name of the vehicle and how much fuel it has. If you did this correctly, all instances should say they have 20 units of fuel, since they all should have been initialized with 10 units.
*/

Car honda = new Car("Lily", "White", "Type 87");
Horse shire = new Horse("Turbo", "Black and White", "Standlee Premium");
Bicycle beachCruiser = new Bicycle("Vroom", "Teal");

//Vehicle test = new Vehicle();
// got an error of cannot create abstract Type


List<Vehicle> myRideList = new List<Vehicle>()
{
    honda,
    shire,
    beachCruiser
};

List<INeedFuel> filterFuelList = new List<INeedFuel>();


foreach(Vehicle v in myRideList)
{
    if(v is INeedFuel){
        filterFuelList.Add((INeedFuel)v);
    }
};


foreach(INeedFuel i in filterFuelList)
{
    i.GiveFuel(10);
}


foreach(INeedFuel i in filterFuelList)
{
    Console.WriteLine(i.FuelTotal);
}