using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryVehicle
{
    class ElectricCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Electric Car");
        }
    }
}