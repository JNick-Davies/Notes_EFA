﻿using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI(); //calling programui.cs and starting that 
            ui.Run();
        }
    }
}