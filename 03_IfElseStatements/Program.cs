using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = false;
            if(userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }

            int hourSpentStudying = 1;
            if(hourSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }

            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun playing video games");
            }
            else
            {
                Console.WriteLine("Finish your chores!"); //can use and or statements to make more complicated 
            }

            Console.WriteLine("How many hours did you sleep?");
            string input = Console.ReadLine(); //console read lines always result in a string!
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("congrats. You are living the dream");
            }
            else
            {
                Console.WriteLine("You should really get more sleep");
                if (totalHours < 3)
                {
                    Console.WriteLine("You're going to turn into a zombie");
                }
            }

            Console.WriteLine("How old are you:?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput); //alternate way of doing the parse way 

            if (age > 17)
            {
                Console.WriteLine("Congrats on being an adult!");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You are a kiddo"); //greater than 6 less than 17
                }
                else if (age > 0)
                {
                    Console.WriteLine("You are a wee bebe"); // age is between 0 and 6
                }
                else
                {
                    Console.WriteLine("You are not even born ");
                }
            }

            if (age > 65 || age < 18)
            {
                Console.WriteLine("You have entered an age greater than 65 OR less than 18.");
            }
        }
    }
}
