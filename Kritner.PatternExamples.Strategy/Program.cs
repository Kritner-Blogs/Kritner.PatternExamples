using Kritner.PatternExamples.Common.Strategy;

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

    

    

    
}
