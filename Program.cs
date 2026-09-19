using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AbstractFactoryVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Gasoline Vehicles ===");
            CreateVehicles(new GasolineVehicleFactory());

            Console.WriteLine();

            Console.WriteLine("=== Electric Vehicles ===");
            CreateVehicles(new ElectricVehicleFactory());

            Console.ReadKey();
        }

        static void CreateVehicles(IVehicleFactory factory)
        {
            IVehicle car = factory.CreateCar();
            car.ShowDetails();

            IVehicle truck = factory.CreateTruck();
            truck.ShowDetails();

            IEngine engine = factory.CreateEngine();
            Console.Write("Standalone engine -> ");
            engine.Start();
        }
    }
}
