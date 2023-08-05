using System.Security.Cryptography.X509Certificates;

namespace CasAdv3Homework
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                ID = 1,
                Type = "Sedan",
                YearOfProduction = 2005,
                BatchNumber = 1,
                FuelTank = 60,
                Countries = "Germany",
            };
            Bike bike1 = new Bike
            {
                ID = 0,
                Type = "gradski",
                YearOfProduction = 2020,
                BatchNumber = 2,
                Color = "red",
            };
            Vehicle vehicle1 = new Vehicle
            {
                ID = 3,
                Type = "Truck",
                YearOfProduction = 0,
                BatchNumber = 555,
            };
            Db.vehicles.Add(car1);
            Db.vehicles.Add(bike1);
            Db.vehicles.Add(vehicle1);

            foreach (var vehicle in Db.vehicles)
            {
                vehicle.PrintVehicle();
            }
            Console.WriteLine();

            foreach (var vehicle in Db.vehicles)
            {
                if (Validator.Validate(vehicle))
                {
                    vehicle.PrintVehicle();
                }
                else
                {
                    Console.WriteLine($"Pogresna oznaka - vechile id: {vehicle.ID}");
                }
            }
        }
    }
}