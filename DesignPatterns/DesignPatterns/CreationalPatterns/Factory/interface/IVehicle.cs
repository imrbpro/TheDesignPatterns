using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    public interface IVehicle
    {
        string VehicleName
        {
            get;
        }
        void start();
        void stop();
    }
}
