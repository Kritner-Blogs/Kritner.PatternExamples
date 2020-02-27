using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.PatternExamples.Common.Strategy
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
