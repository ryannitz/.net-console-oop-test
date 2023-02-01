public class ElectricVehicle : Vehicle
{
    public enum MotorTypes
    {
        Single,
        Dual,
    }

    private MotorTypes MotorType
    { get; set; }

    public ElectricVehicle(string color, string manufacturer, string model, int yearBuilt, MotorTypes motorType)
        : base(color, manufacturer, model, yearBuilt) 
    {
        MotorType = motorType;
    }

    public override string ToString()
    {
        return base.ToString() 
            + "\t MotorType: " + MotorType
            + "\n\t Age: " + CalculateVehicleAge() //This could be moved to parent if we don't care about print order
            + "\n";
    }
}
