using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classese
{
    public enum VechicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat, Submarine }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public VechicleType TypeOfVehicle { get; set; }

        public Vehicle() { }//empty constructor 

        public Vehicle(string make, string model, double mileage, int year, string color, VechicleType tOV) //this is a overload constructor
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            Year = year;
            Color = color;
            TypeOfVehicle = tOV;
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        { get { return $"{FirstName}{LastName}"; } }

        public DateTime DateOfBirth { get; set; }

        public int AgeInYears
        {
            get
            {
                if (DateOfBirth == new DateTime())
                {
                    return 9001;
                }
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYear = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYear));
            }
        }

        public Vehicle Transport { get; set; }


        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = birthday;
        }
    }
}
// things i need to work on
/* debug menu - it crashed last time
 * up load to git
 * classes and methods
 * constrcutors 
 * css store front
 * 
 */