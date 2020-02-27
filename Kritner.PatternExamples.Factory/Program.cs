using Kritner.PatternExamples.Common.Factory;
using Kritner.PatternExamples.Common.Strategy;
using System;

namespace Kritner.PatternExamples.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger logger = null;

            logger = loggerFactory.GetLogger(LoggerType.Console);
            logger.Log($"Doot doot, this should be a {nameof(ConsoleLogger)}.  {logger.GetType()}");

            logger = loggerFactory.GetLogger(LoggerType.File);
            logger.Log($"Doot doot, this should be a {nameof(FileLogger)}.  {logger.GetType()}");
        }
    }
}
