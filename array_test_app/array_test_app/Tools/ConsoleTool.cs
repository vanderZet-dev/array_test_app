using System;
using System.Collections.Generic;
using System.Text;

namespace array_test_app.Tools
{
    public static class ConsoleTool
    {
        public static void WriteLineConsoleGreenMessage(string message) {
            //Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
