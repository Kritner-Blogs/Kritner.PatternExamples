using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.PatternExamples.Common.Strategy
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Gonna have to use our imagination here...
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }
    }
}
