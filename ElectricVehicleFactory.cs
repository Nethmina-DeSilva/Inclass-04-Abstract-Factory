using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryVehicle
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()   { return new GasolineCar(CreateEngine()); }
        public IVehicle CreateTruck() { return new GasolineTruck(CreateEngine()); }
        public IEngine CreateEngine() { return new GasolineEngine(); }
    }
}
