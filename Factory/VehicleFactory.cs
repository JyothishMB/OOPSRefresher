using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class VehicleFactory
    {
        public static IVehicle Create(string type)
        {
            IVehicle vehicle = null;
            if(type.Equals("Bike"))
            {
                vehicle = new Bike();
            }
            else if (type.Equals("Car"))
            {
                vehicle = new Car();
            }
            return vehicle;
        }
    }
}
