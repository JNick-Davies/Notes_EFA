using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings
            string thisIsDeclaration; //string is declared 

            string declared;
            declared = "This is initalixed."; //need " " not ' '

            string declarationAndInitialization = "This is both  declaring and initialzing."; //ctrl +e+w for text wrapping

            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name? " );
            string lastName = Console.ReadLine();

            //Concatenation 
            string concatenatedFullName = firstName + " " + lastName;
            //Composite--> same outcome as concatenation, maybe a preference choice?
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            // interpolation
            string interpolationFullName = $"{firstName} {lastName}";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolationFullName);
            //three ways to get the same result

            // -- Collections
            // Array 
            string stringExample = "Hello Word";
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" }; //[] for string array 

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem); //thirditem is assigned value to be 'why' --> flip this why is assigned to thirditem 
            Console.WriteLine(stringArray[0]);//shoud display hello
            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);//should be hey there 

            // -- List 
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();
            listOfStrings.Add("First string of our list");
            listOfIntegers.Add(4242);
            listOfIntegers.Add(12345);
            Console.WriteLine(listOfIntegers[0]);//should print 4242

            // -- Queue **** this is something to review****
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");//enqueu not add
            firstInFirstOut.Enqueue("I'm next!");
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);

            // --- Dictionaries *** this is something to review****
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");
            string valueSeven = keyAndValue[7];//should return agent? unique key ids cannot dupe them
            Console.WriteLine(valueSeven);

            // -- other collection examples ****look up more on own****
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

            //Console.ReadKey(); //read line is more for input from user readkey maybe be better for stopping the cmd

            //What is the difference between Console.WriteLine and Console.Write??

            // -- classes
            Random rng = new Random(); //setting up to gen a random number 

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);



        }
    }
}
