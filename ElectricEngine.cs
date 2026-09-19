using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryVehicle
{
    public class ElectricEngine: IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline engine started with a roar.");
        }
    }
}
