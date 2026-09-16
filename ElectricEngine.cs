using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryVehicle
{
    class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric Engine Started");
        }
    }
}