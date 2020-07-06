using System;
using System.Collections.Generic;
using _09_StreamingContent_Console;
using _09_StreamingContent_Console.UI;
using _10_StreamingContent_UIRefactorTests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_StreamingContent_UIRefactorTests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainList()
        {
            //arrange!
            List<string> commandList = new List<string> { "1", "5", };
            MockConsole console = new MockConsole(commandList);
            ProgramUI program = new ProgramUI(console);

            //act
            program.Run();
            Console.WriteLine(console.Output);

            //assert
            Assert.IsTrue(console.Output.Contains("Japanese Fraiser"));
        }
        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            //arragne
            var customDesc = "This is my custom description";
            var commandList = new List<string> { "3", "Title", customDesc, "4", "1", "8", "1", "5" }; //arranged in the order of the walk thru for the program 
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console); //using fake console

            //act
            ui.Run();
            Console.WriteLine(console.Output);

            //assert
            Assert.IsTrue(console.Output.Contains(customDesc));
        }
    }
}

