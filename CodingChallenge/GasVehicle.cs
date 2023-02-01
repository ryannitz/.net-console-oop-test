public class GasVehicle : Vehicle
{
    public enum EngineSizes
    {
        Four,
        Six,
        Eight
    }

    private EngineSizes EngineSize
    { get; set; }

    public GasVehicle(string color, string manufacturer, string model, int yearBuilt, EngineSizes engineSize)
        : base(color, manufacturer, model, yearBuilt) 
    {
        EngineSize = engineSize;
    }

    public override string ToString()
    {
        return base.ToString()
            + "\t EngineSize: " + EngineSize
            + "\n\t Age: " + CalculateVehicleAge() //This could be moved to parent if we don't care about print order
            + "\n";
    }

}
