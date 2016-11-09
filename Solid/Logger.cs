using System;

namespace Solid
{
    public class Logger
    {
        private IMessageLogger messageLogger;

        public Logger(IMessageLogger logger)
        {
            messageLogger = logger;
        }

        public void Log(string message)
        {
            messageLogger.Log(message);
        }
    }

    public interface IMessageLogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class PrintLogger : IMessageLogger
    {
        public void Log(string message)
        {
            //Code to send to printer
        }
    }
}
