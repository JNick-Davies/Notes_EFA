using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();  //martha is a new person class 
            martha.PhoneNumber = "8675309";

            Customer bob = new Customer(); //bob has access to person and customer class because of inhertiance 
            bob.PhoneNumber = "123-1234";

            SalaryEmployee ted = new SalaryEmployee
            {
                PhoneNumber = "fakeNumber", //again inheritance at work here 
                Salary = 120000,
                HireDate = new DateTime(1304, 01, 01),
            };
            Console.WriteLine(ted.YearsWithCompany); //cw must be within the method bruh 
        }
        [TestMethod]
        public void CustomerIsPremium_ShouldGetCorrectBool() //test method using a new thing
        {
            Customer firstCustomer = new Customer();
            firstCustomer.IsPremium = true; //this is a peremium customer
            Person newPerson = new Person();
            Console.WriteLine(newPerson.GetType());//gets class of what it is
            Console.WriteLine(firstCustomer.GetType()); //get type looks at what it is attached to and gets the type
            Assert.IsTrue(firstCustomer.IsPremium);
        }
        [TestMethod]
        public void Employee()
        {
            Employee jarvis = new Employee();//objects to work with 
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            tony.HoursWorked = 55;
            tony.HourlyWage = 9003;
            pepper.Salary = 2000000;

            List<Employee> allEmployees = new List<Employee>();//rules of list that lists can hold ONE thing
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper); //no error bc they are inherite from the base class
            //tony.SetFirstName = "Tony Stark"; this line does not work as it is read only  
            //tony.SetFirstName("Tony"); this line works and is a preference choice on how to write this 

            foreach (Employee worker in allEmployees)
            {
                if (worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker; //casting
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.Salary}");
                }
                else if (worker is HourlyEmployee hourlyWorker) //pattern matching taking working turning it into hourley worker and making a new variable in the IF statement 
                {
                    //HourlyEmployee hEmployee = (HourlyEmployee)hourlyWorker; 
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }//polymorphism is the P in API ... classes related thru inheritance ...uses methods to preform tasks in different ways ...one method that can do serval functionality 
        }
    }
}
