using CarsAndUsedCars;
int choice = -1;

// List 
List<Car> CarList = new List<Car>()
{
new UsedCar("Ford", "Explorer", 2020, 80000, 36000),
new UsedCar("Chevy", "Sonic", 2015, 15000, 68900),
new UsedCar("Dodge", "Durango", 2018, 17800, 150000),
new Car("Tesla", "Model X", 2022, 250000),
new Car("Jeep", "Wrangler", 2023, 79000),
new Car("Ford", "Bronco Sport", 2023, 68000),
};

Car.ListCars(CarList);

Console.WriteLine($"Which number car 1-{CarList.Count} would you like?");
try
{
    choice = int.Parse(Console.ReadLine());
    if(choice < 1 || choice > CarList.Count)
    {
        throw new Exception("Please pick a valid number.");
    }
}
catch (FormatException e)
{
    Console.WriteLine("Error, that is not a number");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



