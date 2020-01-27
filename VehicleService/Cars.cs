using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleService
{
    class Cars : Vehicles
    {

        public override void Generic()
        {
            Console.WriteLine("Muffler replacement completed \n--------------------------------------------");
        }
    }
}
