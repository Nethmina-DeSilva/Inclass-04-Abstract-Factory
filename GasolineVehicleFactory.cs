using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryVehicle
{
    class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new GasolineCar();
        }

        public IVehicle CreateTruck()
        {
            return new GasolineTruck();
        }

        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }
    }
}