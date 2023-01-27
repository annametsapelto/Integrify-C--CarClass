// See https://aka.ms/new-console-template for more information
Motor SmallMotor = new Motor("Type 1", 2000, 500);

Car Volvo1 = new Volvo(CarType.Passenger, 2020, SmallMotor, "red", "V60", 5, FuelType.Gasoline);

Console.WriteLine("The color of the car is " + Volvo1.Color + ". It uses " + Volvo1.Fuel + " as fuel.");


