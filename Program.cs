using CarsAndUsedCars;

// List 
List<Car> CarList = new List<Car>();

UsedCar explorer = new UsedCar("Ford", "Explorer", 2020, 80000, 36000);
UsedCar sonic = new UsedCar("Chevy", "Sonic", 2015, 15000, 68900);
UsedCar durango = new UsedCar("Dodge", "Durango", 2018, 17800, 150000);
Car modelX = new Car("Tesla", "Model X", 2022, 250000);
Car wrangler = new Car("Jeep", "Wrangler", 2023, 79000);
Car broncoSport = new Car("Ford", "Bronco Sport", 2023, 68000);

CarList.Add(modelX);
CarList.Add(explorer);
CarList.Add(broncoSport);
CarList.Add(durango);
CarList.Add(wrangler);
CarList.Add(sonic);


