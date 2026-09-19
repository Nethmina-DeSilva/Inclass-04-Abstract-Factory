using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactoryVehicle
{
    public class GasolineCar: IVehicle
    {
        private readonly IEngine _engine;

        public GasolineCar(IEngine engine)
        {
            _engine = engine;
        }

        public void ShowDetails()
        {
            Console.WriteLine("This is a Gasoline Car.");
            _engine.Start();
        }
    }
}
