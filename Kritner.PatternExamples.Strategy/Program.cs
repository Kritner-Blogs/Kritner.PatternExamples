using System;

namespace Kritner.PatternExamples.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = null;

            logger = new ConsoleLogger();
            logger.Log($"Doot doot, this should be a {nameof(ConsoleLogger)}.  {logger.GetType()}");

            logger = new FileLogger();
            logger.Log($"Doot doot, this should be a {nameof(FileLogger)}.  {logger.GetType()}");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

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
