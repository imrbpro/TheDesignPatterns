using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory.implementation
{
    public class Truck : IVehicle
    {
        public string VehicleName => "Truck";

        public void start()
        {
            Console.WriteLine("I am a Truck and I am going to start.");
        }

        public void stop()
        {
            Console.WriteLine("I am a Truck and I am going to stop.");
        }
    }
}
