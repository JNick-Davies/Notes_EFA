using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ternaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 77;
            // (condition/boolean) ? trueResults : falseResults <-- ternary 
            //bool isAdult = (age > 17) ? true : false; //ternary syntax 
            bool isAdult = (age > 17) ? true : false;

            int numOne = 62;
            int numTwo = (numOne == 10) ? 30 : 40;

            int hoursAsleep = 4;
            string outcome = (hoursAsleep >= 8) ? "Congrats" : "sorry 'bout cha";
        }
    }
}
