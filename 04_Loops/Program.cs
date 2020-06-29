using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops //ctrl+K+D lines up code 
{
    class Program //also _ indicates field ex. _erick
    {
        static void Main(string[] args)
        {
            //While loop
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1; //adding one until we reach 10
            }

            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("you did it!");
                    break;
                }
                total++;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

            // for loop
            int studentCount = 21;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }//...this counts to 21

            string[] students = { "Nick", "Adam", "AJ", "Austin", "Severa", "Tim" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there! {students[i]}!"); //displays hello there! [student name]
            }//*****practice with fizz buzz loop program ******

            // for each
            foreach (string student in students)//change student to bananas ..still works be this line makes the string student from the array studentS on line 57
            {
                Console.WriteLine(student + " is in the class today");
            }

            string myName = "John Nicholas Davies";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            //do while loop is different from a while loop as this loop will exectute at least one then check its conditional 
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            }
            while (false);

            while (false)
            {
                Console.WriteLine("This is a test");
            }
            Console.ReadKey();

        }
    }

}

