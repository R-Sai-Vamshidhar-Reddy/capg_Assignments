using System;

namespace Assessmentc_
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Simulate logging to a file
            Console.WriteLine($"FileLogger: {message}");
        }
    }

    public abstract class LoggerDecorator : ILogger
    {
        protected readonly ILogger _logger;

        protected LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public abstract void Log(string message);
    }

    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestampedMessage = $"{DateTime.Now}: {message}";
            _logger.Log(timestampedMessage);
        }
    }

    public class ErrorCategorizationLogger : LoggerDecorator
    {
        public ErrorCategorizationLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string categorizedMessage = $"Error: {message}";
            _logger.Log(categorizedMessage);
        }
    }

    
}
