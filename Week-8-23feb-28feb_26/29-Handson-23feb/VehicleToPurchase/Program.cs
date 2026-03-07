namespace VehicleToPurchase
{
    internal class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle("Car", 30000),
            new Vehicle("Bike", 20000),
            new Vehicle("Truck", 50000),
            new Vehicle("Scooter", 15000)
        };

            VehicleImplementation obj = new VehicleImplementation();

            Console.WriteLine("Sum of Prices: " + obj.SumOfPrices(vehicles));

            Console.WriteLine("Vehicles priced above 25000:");
            foreach (var v in obj.GetVehicleList(vehicles))
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Maximum Price: " + obj.MaxPrice(vehicles));
        }
    }

}