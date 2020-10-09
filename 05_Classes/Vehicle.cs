using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Boat, Rocket, Hovercraft, Submarine }
    public class Vehicle
    {
        //Fields and Properties
        public string Make { get; set; }
        //underscore means private field, meaning it can only be accessed with this class
        private string _model;

        public void SetModel(string model)
        {
            if (model == model.ToLower())
            {
                //capitalize
            }
            _model = model;
        }
        public string GetModel()
        {
            return _model;
        }
        //prop tab tab
        public double Mileage { get; set; }

        public VehicleType TypeofVehicle { get; set; }

        public bool IsRunning { get; private set; }


        //Constructors
        //empty constructor
        public Vehicle()
        {

        }

        //full constructor
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            _model = model;
            Mileage = mileage;
            TypeofVehicle = type;
        }

        //partial constructor
        public Vehicle(VehicleType type, string model)
        {
            TypeofVehicle = type;
            _model = model;

            DateTime now = new DateTime();
        }

        //Methods
        public void TurnOn()
        {
            if (IsRunning)
            {
                Console.WriteLine("It's already on");
            }
            else
            {
                IsRunning = true;
                Console.WriteLine("You turned the vehicle on.");
            }
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You shut it off.");
        }
    }
}
