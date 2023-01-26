public class Motor {
    private string _motorType {get; init;}
    private int _power {get; init;}
    private int _engineCapacity {get; init;}

    public Motor(string _motorType, int _power, int _engineCapacity) {
        this._motorType = _motorType;
        this._power = _power;
        this._engineCapacity = _engineCapacity;
    }
}