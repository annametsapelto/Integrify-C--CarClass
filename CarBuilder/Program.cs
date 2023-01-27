using static System.Console; 
Motor SmallMotor = new Motor("Type 1", 2000, 500);

Car Volvo1 = new Volvo(CarType.Passenger, 2020, SmallMotor, "red", "V60", 5, FuelType.Gasoline);

WriteLine("The color of the car is " + Volvo1.Color + ". It uses " + Volvo1.Fuel + " as fuel.");

Volvo1.Repaint("black");

WriteLine(Volvo1.Color);

WriteLine("This car has the velocity of " + Math.Round(Volvo1.CountVelocity(), 4) + ".");



