public class Vehicle : IVehicle, IComparable<Vehicle>
{

	public Vehicle(string color, string manufacturer, string model, int yearBuilt)
	{
		Color = color;
		Manufacturer = manufacturer;
		Model = model;
		YearBuilt = yearBuilt;
	}

	public string Color
	{ get; set; }

	public string Manufacturer
    { get; set; }

    public string Model
    { get; set; }

    public int YearBuilt
    { get; set; }

	public int CompareTo(Vehicle? other)
	{
		if(other == null)
		{
			return 1;
		}
        return this.GetType().Name.CompareTo(other.GetType().Name);
	}

	public int CalculateVehicleAge()
	{
		int currentYear = DateTime.Now.Year;
		return currentYear - YearBuilt;
	}

	public override string ToString()
	{
		return "\t Color: " + Color 
			+ "\n\t Manufacturer: " + Manufacturer 
			+ "\n\t Model: " + Model 
			+ "\n\t Year Built: " + YearBuilt 
			+ "\n";
	}
}
