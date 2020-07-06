using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public class Cat : Animal //public is always needed for inheritance 
    {
        public double ClawLength { get; set; }
        public virtual void MakeSounds()//virtual method can be redefined ..virtual is not an access modifier .. it's keyword ..like static 
        {
            Console.WriteLine("Meow");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly."); //override other method 
        }
    }

    public class Liger : Cat
    {
        public override void MakeSounds()
        {
            Console.WriteLine("Roar"); //this is the actual override 
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks it's prey");
            base.Move();
        }
    }

    public class TabbyCat : Cat
    {
        public override void MakeSounds()
        {
            base.MakeSounds();
            Console.WriteLine("Purr!");
        }
    }
    
}
