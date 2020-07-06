using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactorTests.UI
{
    public class MockConsole : IConsole //using IConsole here needs a reference to 09_ bc this is not in the same namespace 
    {
        public Queue<string> UserInput;
        public string Output;
        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);
            Output = "";
        }

        public void Clear()
        {
            Output += "Called Clear Method \n"; //this will show that the method was called 
            //Output = Output + "Called Clear Method \n"; does the same as the line about it with the +=
        }
        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            return UserInput.Dequeue(); //called it takes user input next from queue should be the next command in the list ...so when building the list, the order of the list is important 
        }
        public void WriteLine(string s)
        {
            Output += s + "\n";
        }

        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
