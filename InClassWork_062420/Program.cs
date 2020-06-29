using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InClassWork_062420
{
    enum menuItems { Alfredo, Chicken, Eggplant, PeneRagu, Parm  };
    class Program
    {
        static void Main(string[] args)
        {//01
            string restaurant = "Tony's";
            string price = "49.95";
            double buffettPrice = Convert.ToDouble(price);
            DateTime today = new DateTime(2020, 06, 24);
            menuItems special = menuItems.Alfredo;
            char happyGuests = '9';
            bool guestsLoveUs = true;
            menuItems altSpecial = menuItems.Parm;
            string chicken = "Chicken " + altSpecial;
            string eggplant = "Eggplant " + altSpecial;
            Console.WriteLine("{0} Resutaurnt buffet starts at ${1}", restaurant, buffettPrice);
            Console.WriteLine("{0} is open {1})", restaurant, today);
            Console.WriteLine("{0} recommends today's special the {1}", restaurant, special);
            Console.WriteLine($"Be on the lookout for our other specials {chicken} and {eggplant}");
            Console.WriteLine(happyGuests + "/10 guests love eating at {0}", restaurant);
            Console.WriteLine("Dont take our word for it, ask the computer! Do our guests love us? " + guestsLoveUs);
            //02
            int a = 42;
            int b = 5;
            double first = b * a;
            double second = a + b;
            double third = b + 3;
            double bonus1 = (a * 2) + b;
            double bonus2 = ((b * 5) / a);
            Console.WriteLine("answers: {0}, {1}, {2}, {3}, {4},", first, second, third, bonus1, bonus2);
            //string day;
            //bool testComparison = 
            Console.ReadKey();
        }
    }
}
