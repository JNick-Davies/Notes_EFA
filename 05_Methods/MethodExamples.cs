using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        //1 Acess Modifier
        //2 Return Type
        //3 Method Signature
        //4 Body 
        public void MethodExecution() //test method is declared within the class (public class) --> named to TestMethod...'public' is an acess modifier..how and who is able to access this method...return type = 'void' means not returning anything (type) other ways can return a string or an int..../3 method signature method name and parameters name = TestMethod1 with no parameters.../4 Body within {} under public void TestMethod 
        {
            SayHello("Erick"); //can do with because within same class
            SayHello("there: general kenobi"); //this is the arguemnt 

            int inputOne = 7;
            int inputTwo = 13;
            int sum = AddTwoNumber(inputOne, inputTwo);
            Console.WriteLine(sum);
            double doubleSum = AddTwoNumber(242.2d, 234.5d);

            int myAge = CalculateAge(new DateTime(1892, 11, 24));
            Console.WriteLine("My age is: " + myAge);

        }
        public void SayHello(String name)//names method with intent - what does it do METHODS HAVE PASCHAL CASING 
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int AddTwoNumber(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double AddTwoNumber(double one, double two)//double not int 
        {
            double sum = one + two;
            return sum;
        }

        private int CalculateAge(DateTime birthday) //figuring out how old someone is
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totlaAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totlaAgeInYears));
            return years;
        }
    }
}
