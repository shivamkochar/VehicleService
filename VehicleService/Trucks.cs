using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleService
{
    class Trucks : Vehicles
    {
        public override void Generic()
        {
            Console.WriteLine("Truck bed installation completed \n----------------------------------");
        }
    }
}
