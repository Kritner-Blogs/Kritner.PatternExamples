using Kritner.PatternExamples.Common.Strategy;

namespace Kritner.PatternExamples.Common.Factory
{
    public interface ILoggerFactory
    {
        ILogger GetLogger(LoggerType loggerType);
    }
}
