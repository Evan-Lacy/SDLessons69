using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_KI_Cars.Vehicles
{
    public interface IVehicle
    {
//        Komodo Insurance wants you to clean up some of their software by creating methods 
//            that use all of their different types of vehicles.Before that can be done, 
//            you know they need to make an interface that can be implemented on all of their classes.
//            KI has all of their vehicle types (sedans, SUV, motorcycle, etc) sharing similar attributes and actions. 
//                All vehicles need to be able to start, turn off, drive, as well as they all have a make, model, and color.


//To demonstrate the benefits, make the interface and a few example classes.Write a few tests as well showing the power of the new interface.

        //start
        bool IsStarted { get; }
        //turn off
        bool IsOff { get; }
        //drive
        string Drive();
        //make
        string Make { get; }
        //model
        string Model { get; }
        //color
        string Color { get; }

        void Drive();
        void Start();
        void TurnOff();
    }
}
