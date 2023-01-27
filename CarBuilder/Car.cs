public abstract class Car {
    public CarType CarType {get; init;}
    public int ManufactureYear {get; init;}
    public Motor Motor {get; init;}
    public string Color {get; set;}
    public string Make {get; init;}
    public string Model {get; init;}
    public int NumberOfSeats {get; set;}
    public FuelType Fuel {get; set;}

    public void Repaint(string NewColor)
    {
        this.Color = NewColor;
        Console.WriteLine("This car has been repainted. It is now " + NewColor + ".");
    }

    public abstract double CountVelocity(); 
}