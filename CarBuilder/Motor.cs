public class Motor 
{
    public string MotorType {get; init;}
    public int Power {get; init;}
    public int EngineCapacity {get; init;}

    public Motor(string _motorType, int _power, int _engineCapacity) {
        this.MotorType = _motorType;
        this.Power = _power;
        this.EngineCapacity = _engineCapacity;
    }
}