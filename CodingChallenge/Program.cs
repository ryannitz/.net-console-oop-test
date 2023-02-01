public class Program
{
    static readonly string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo" }; //rainbow colors :)
    static readonly string[] manufacturers = { "Ford", "Chevy", "Cadillac", "Tesla", "Bmw", "Lotus", "Kia", "Toyota" };
    static readonly string[] models = { "F-150", "Model Y", "Spark", "Tundra", "Camry", "Rio", "Forte", "Esprit", "DeVille", "Camaro", "M6", "Focus" };
    static readonly int vehicleCount = 10;


    public static void Main(string[] args)
    {
        Console.WriteLine(""); //My terminal eats the first Console.WriteLine() and doesn't display. Maybe need to look at some buffer controls
        
        List<Vehicle> vehicles = new List<Vehicle>(vehicleCount);
        for (int i = 0; i < vehicleCount; i++)
        {
            vehicles.Add(GenerateRandomVehicle());
        }
        vehicles.Sort();
        PrintVehicleList(vehicles);
    }


    public static Vehicle GenerateRandomVehicle()
    {
        Vehicle newVehicle;
        Random random = new Random(); //realistically not a great spot to recreate 'random' objects
        if(random.Next(0,2) == 0)
        {
            newVehicle = new GasVehicle(
                colors[random.Next(colors.Length)],
                manufacturers[random.Next(manufacturers.Length)],
                models[random.Next(models.Length)],
                random.Next(1970, DateTime.Now.Year),
                GetRandomEngineSize()
                );
        } 
        else
        {
            newVehicle = new ElectricVehicle(
                colors[random.Next(colors.Length)],
                manufacturers[random.Next(manufacturers.Length)],
                models[random.Next(models.Length)],
                random.Next(1970, DateTime.Now.Year),
                GetRandomMotorType()
                );
        }
        return newVehicle;
    }


    /*
        Printing in a loop is the most resource-hungry process. 
        To optimize, you could build the string and then use one print statement. 
    */
    public static void PrintVehicleList(List<Vehicle> vehicles)
    {
        for (int i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine("Car {0}:", i + 1);
            Console.WriteLine(vehicles[i].ToString());
        }
    }


    /*
        I wonder if we could move these to the respective car classes? NO! These exist solely to pick a random enum.
        For the sake of the example, I am not addressing/suppressing the possible null value
     */
    public static GasVehicle.EngineSizes GetRandomEngineSize()
    {
        Random random = new Random();
        Array engineSizes = Enum.GetValues(typeof(GasVehicle.EngineSizes));
        //assigning a value in case we want to do some null checking.
        GasVehicle.EngineSizes engineSize = (GasVehicle.EngineSizes)engineSizes.GetValue(random.Next(engineSizes.Length));
        return engineSize;
    }


    /*
        I wonder if we could move these to the respective car classes? NO! These exist solely to pick a random enum
        For the sake of the example, I am not addressing/suppressing the possible null value
    */
    public static ElectricVehicle.MotorTypes GetRandomMotorType()
    {
        Random random = new Random();
        Array motorTypes = Enum.GetValues(typeof(ElectricVehicle.MotorTypes));
        ElectricVehicle.MotorTypes motorType = (ElectricVehicle.MotorTypes)motorTypes.GetValue(random.Next(motorTypes.Length));
        //assigning a value in case we want to do some null checking
        return motorType;
    }
}
