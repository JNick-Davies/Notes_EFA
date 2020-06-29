using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string Winner = "Fizzbuzz";
            string divByFour = "Fizz";
            string divBySeven = "Buzz";
            for (int i = 1; i <= 200; i++)
                if (i % 4 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(Winner);
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine(divByFour);
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine(divBySeven);
                }
                else
                {
                    Console.WriteLine(i);
                }

            Console.ReadKey();
        }
    }
}
