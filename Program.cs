using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryVehicle
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = new ElectricVehicleFactory();
            IVehicle truck = factory.CreateTruck();
            IVehicle car = factory.CreateCar();
            IEngine engine = factory.CreateEngine();

            car.ShowDetails();
            truck.ShowDetails();
            engine.Start();
        }
    }
}
