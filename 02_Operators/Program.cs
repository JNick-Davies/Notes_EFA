using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 11;

            //addition

            int sum = a + b;
            Console.WriteLine(sum); //look at syntax here

            //subtraction

            int difference = a - b;
            Console.WriteLine(difference);

            //multiplication
            int product = a * b;
            Console.WriteLine(product); //ans:77

            //division 
            int quotient = a / b;
            Console.WriteLine(quotient); //ans:0

            //remainder
            int remainder = a % b;
            Console.WriteLine(remainder); //ans:7 this divides and the generates answer as the remainder ex 5/4=1r1 ans = 1 
            int a1 = 5;
            int b2 = 4;
            int remainder1 = a1 % b2;
            Console.WriteLine(remainder1);
            int a2 = 20;
            int b3 = 2;
            int remainder2 = a2 % b3;
            Console.WriteLine(remainder2);//ans 0

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1842, 1, 1);
            TimeSpan timeSpan = now - someDay; //date counter!!
            Console.WriteLine(timeSpan); //requires formating for a time span this gens a integer #
            //possible formating : day.hours:minutes:seconds.milliseconds (or microseconds or something)

            //Comparison Operators (loops and ifs use these alot)
            Console.WriteLine("Enter your age: ");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);//convert string to int if user doesnt enter number type... this breaks
            Console.WriteLine("Enter your name: ");
            string username = Console.ReadLine();
            bool equals = age == 41;
            bool userIsFrank = username == "Frank"; //case sentitive.. if frank, 41, doesent type this in right it is false
            Console.WriteLine("User is 41: " + equals); //concatinate example of string manipulation 
            Console.WriteLine("User is Frank: " + userIsFrank);

            bool notEqual = age != 113; //throw false if 113, true else
            bool userIsNotJustin = username != "Justin";
            Console.WriteLine($"User is not 113: {notEqual}"); //string manip
            Console.WriteLine($"User is not Justin: {userIsNotJustin}");

            //change

            List<string> firstList = new List<string>();//firstList is name of list, new list sets up the list and string after list is what the list holds~!
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listAreEqual = firstList == secondList;
            Console.WriteLine(listAreEqual);
            //why isnt this true?..value returns false ...something to do with stack and heap
            //stacks (firstList and secondList point to 2 boxes on the heap with same value but are different ... person has same name but diff age?.. proabably shouldnt compare lists 

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 55; //syntex examples below
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 99;
            //bool and & ors
            bool orValue = equals || lessThan; //shift plus key above the enter key to get |
            //operator above is set to true if one of the other operators is true 

            bool tOrT = true || true; //comparison values
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false; //so long as true is on one side it should be true

            bool andValue = greaterThan && orValue; //both greaterThan and orValue must be true to return a true result 
            bool tAndT = true && true;
            bool tAndF = true && false; //false
            bool fAndT = false && true;
            bool fAndF = false && false;

            //if x greater 10 but less than 44
            int x =3;
            bool test = x < 44 && x > 10; //this wont work? **** check it out

            


            Console.ReadKey();
            
        }
    }
}
