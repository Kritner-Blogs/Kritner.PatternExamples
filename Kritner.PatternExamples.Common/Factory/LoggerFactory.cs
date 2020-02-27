using Kritner.PatternExamples.Common.Strategy;
using System;

namespace Kritner.PatternExamples.Common.Factory
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger(LoggerType loggerType)
        {
            switch (loggerType)
            {
                case LoggerType.Console:
                    return new ConsoleLogger();
                case LoggerType.File:
                    return new FileLogger();
                default:
                    throw new ArgumentException($"{nameof(loggerType)} was invalid.");
            }
        }
    }
}
