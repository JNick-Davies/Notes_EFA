using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _06_Classese
{
    public class ClassTests
    {
        [TestMethod]

        public void VechiclePropertyTest()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Color = "Yellow";
            Console.WriteLine(firstVehicle.Color);
            firstVehicle.Make = "Caddillac";
            firstVehicle.Model = "DTS";
            firstVehicle.Mileage = 7;
            firstVehicle.Year = 2018;
            firstVehicle.TypeOfVehicle = VechicleType.Car;

            string carDetails = $"{firstVehicle.Make} {firstVehicle.Color}";
            Console.WriteLine(carDetails);

            Vehicle myVehicle = new Vehicle();
            myVehicle.Year = 2025;

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy",90000, 2015, "space grey", VechicleType.Spaceship);//constructor add all values instead of typing out lines ~14 to 20..does not execute a Conesole write line
            //C# | Constructors. A constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created. Like methods, a constructor also contains the collection of instructions that are executed at the time of Object creation.

            Vehicle submarine = new Vehicle("Deep Sea", "Atlantis", 50000, 2012, "Camo", VechicleType.Submarine);




        }

        [TestMethod]
        public void PersonTests()
        {
            Person amanda = new Person("Appa", "YipYip", new DateTime(2001,06,11));
            Console.WriteLine(amanda.AgeInYears);
            Console.WriteLine(amanda.FullName);

            Person newPerson = new Person("Zuko", "FireLord", new DateTime(1990, 06, 22));
            newPerson.Transport = new Vehicle("Pontiac", "Firebird", 100000, 1989, "Red & Gold", VechicleType.Car);
            Console.WriteLine(newPerson.Transport.Model);//should output firbird 

            Assert.AreEqual("Zuko FireLord", newPerson.FullName);
        }
    }
}
