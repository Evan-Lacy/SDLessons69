using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            Greeter greeter = new Greeter();

            //1 - this is an argument, whereas in the class itself, it is called a parameter
            //                  1
            greeter.SayHello("Evan");

            string greeting = greeter.GetRandomGreeting().ToLower();

            greeting = "Random Greeting: " + greeting;
            greeter.SaySomething(greeting);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Calculator calculator = new Calculator();

            int thirtyTwo = calculator.Power(2, 5);
            Console.WriteLine(thirtyTwo);
        }
        [TestMethod]
        public void Remainder()
        {
            Calculator calculator = new Calculator();

            int oneHopefully = calculator.Remainder(10, 3);
            Console.WriteLine(oneHopefully);
        }

        [TestMethod]
        public void DoubleAddition()
        {
            Calculator calculator = new Calculator();

            double mathHopefully = calculator.Add(210.35, 210.34);
            Console.WriteLine(mathHopefully);
        }

        [TestMethod]
        public void DoubleSubtraction()
        {
            Calculator calculator = new Calculator();

            double mathHopefully = calculator.Subtract(210.35, 25.000000540034);
            Console.WriteLine(mathHopefully);
        }

        [TestMethod]
        public void Division()
        {
            Calculator calculator = new Calculator();

            double mathHopefully = calculator.Divide(210, 21);
            Console.WriteLine(mathHopefully);
        }

        [TestMethod]
        public void VehicleTest()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "Chevy";
            vehicle.SetModel("Chevy Equinox");

            Console.WriteLine(vehicle.Make);
            Console.WriteLine(vehicle.GetModel());

            vehicle.TurnOn();
            vehicle.TurnOn();
            vehicle.TurnOff();
        }

        [TestMethod]
        public void PersonTest()
        {
            Person evan = new Person("Evan", "Lacy", new DateTime(1997, 01, 30));
            Vehicle car = new Vehicle(VehicleType.Car, "Sebring");
            evan.Transport = car;

            Console.WriteLine(evan.FullName);
            Console.WriteLine(evan.Age);
            Console.WriteLine(evan.Transport.TypeofVehicle);
        }

        [TestMethod]
        public void UserTest()
        {
            DateTime dob = new DateTime(1997, 01, 30);
            User user = new User("Evan", "Lacy", 5, dob);

            Console.WriteLine(user.GetYears());
        }
    }
}
