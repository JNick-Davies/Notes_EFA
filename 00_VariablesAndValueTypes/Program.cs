using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish };
    //not camel case, paschal case
    class Program
    {
        static void Main(string[] args)
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false; //
            isDeclaredAndInitialized = true; //can change value of variable code runs top to bottom

            char character = 'a';//single quotes
            char symbol = '&';
            char number = '5'; //cant be 55, cahr is only ever one
            char space = ' '; //note it can be space
            char specialCharacter = '\n'; //two character special rules \n means goto new line? --> action 

            //null is nothing =/= 0

            //whole numbers
            byte byteExample = 255; //255 is the highest it can go
            sbyte sByteExample = -128;
            short shortExample = 32767; //same as Int16 prefences to use one or int16
            Int16 anotherShortExmaple = 32000;
            int intMin = -2147483648; //smallest value 
            Int32 intMax = 2147483647; //max value of an integer 
            long longExample = 9223372036854775807; //max value
            Int64 longMin = -9223372036854775808; //min value

            int a = 7;
            int b = -7000; //right side of the equal sign is what is run first. So -7000 processes first and then is assigned the variable of 'b'

            byte age = 104;

            //decimals
            float floatExample = 1.045231f; //f makes this a float f is very important 
            double doubleExample = 1.789053278907036d; //d is the suffix --> not ciritcal to have d, it is the standard form. can be removed with no issues
            decimal decimalExample = 1.2578907289045789789789789787897m; //m suffix, very long decimal point
            Console.WriteLine(1.2578907289045789789789789787897f);
            //cw then tab tab opens the console write line
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);//when running with diff suffixes you can see there is a cut off point in decimals.

            Console.ReadKey(); //prompts user to say hey i need input 

            // Enums -->declared outside of the class then used in the class --> static values that will not change

            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            //Structs 

            Int32 num = 42;//if value is unassigned it defaults to 0 
            DateTime today = DateTime.Today; //assigns value of today
            DateTime birthday = new DateTime(1805, 11, 24);//very powerful option use arrow keys to see 12 options
            DateTime test = new DateTime(); //do not use 'default' as a variable name... name with intent


        }
    }
}

