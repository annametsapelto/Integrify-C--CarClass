public abstract class Car {
    public CarType CarType {get; init;}
    public int ManufactureYear {get; init;}
    public Motor Motor {get; init;}
    public string Color {get; set;}
    public string Make {get; init;}
    public string Model {get; init;}
    public int NumberOfSeats {get; set;}
    public FuelType Fuel {get; set;}
}