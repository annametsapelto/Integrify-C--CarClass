public class Ford: Car {
    private string _make = "Ford";

    public Ford(CarType _carType, int _manufactureYear, Motor _motor, string _color, string _model, int _numberOfSeats, FuelType _fuel) {
        this.CarType = _carType;
        this.ManufactureYear = _manufactureYear;
        this.Motor = _motor;
        this.Color = _color;
        this.Model = _model;
        this.NumberOfSeats = _numberOfSeats;
        this.Fuel = _fuel;
    }
}