using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public class Sloth : Animal
    {
        public bool IsSlow
        {
            get { return true; }
        }
         public override void Move() //must be inherited
        {
            Console.WriteLine("The Sloth moves Slowly");
        }
    }
    public class Megatherium : Sloth
    {
        public override void Move()
        {
            Console.WriteLine("Megatherium uses move! It's not super effective...");//this sloth is extinct 
        }
    }
}
