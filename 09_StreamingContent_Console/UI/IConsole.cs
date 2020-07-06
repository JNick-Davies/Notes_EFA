using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public interface IConsole //we're building an interface. were setting this up to test the console. Building a fake console to test 
        //taking console out the picture to test 
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Clear();
        string ReadLine(); //all these functions appear in our program
        ConsoleKeyInfo ReadKey();
    }
}

