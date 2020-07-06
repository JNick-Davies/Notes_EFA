using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Employee : Person //you can only inherite once. 
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25; //right click and peak definition to see meta data 
                return Convert.ToInt32(Math.Floor(totalTime)); //math is a class, floor is a method 
            }
        }
    }

    public class HourlyEmployee : Employee //classes green, modifiers blue, props white 
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
    }
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

    }
}
