using CarsAndUsedCars;
int choice = -1; // will be used later 

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

Console.WriteLine("Welcome to Detroit Rides! \nHere is what we currently have available: \n");

// list out full list of cars 
Car.ListCars(CarList);
Console.WriteLine(" "); // just adding space :) 

//collect user data - don't proceed until we have valid input

while (true)
{
    Console.WriteLine($"Which number car (1-{CarList.Count}) would you like? \n");
    try
    {
        choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > CarList.Count)
        {
            throw new Exception("Please pick a valid number.");
        }
        else
        {
            break; // so we can exit this loop and move on 
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
}

// any \n is just a new line, so we don't have a ton of blank WriteLine statements.

Console.WriteLine($"You've chosen: {CarList[choice - 1].ToString()}\n");
//Console.WriteLine(CarList[choice -1].ToString());

Console.WriteLine("Thank you! Our finance department will call you this afternoon.\n"); 

// using the Remove() function to remove CHOICE from the list 
Car.Remove((choice - 1), CarList);

Console.WriteLine("Here is the remaining list of cars available: \n");

// displaying the updated list of cars 
Car.ListCars(CarList);

Console.WriteLine("Have a great day!");
