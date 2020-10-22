using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_KI_Cars.Vehicles
{
    public class Sedan : IVehicle
    {
        public bool IsStarted { get; private set; }

        public bool IsOff { get; private set; }

        public string Drive()
        {
            if (IsStarted == true)
            {
                //Console.WriteLine("The Car is started and can drive");
                IsOff = false;
                return "The Car is started and can drive.";
            }
            else
            {
                //Console.WriteLine("The car cannot drive");
                IsStarted = false;
                IsOff =  true;
                return "The car cannot drive.";
            }
        }

        public string Make { get; private set; }

        public string Model { get; private set; }

        public string Color { get; private set; }
    }
}
