using System;

namespace SolidWrong
{
    class Logger
    {
        public void Log(string message, LogType logType)
        {
            switch (logType)
            {
                case LogType.Console:
                    Console.WriteLine(message);
                    break;
                case LogType.File:
                    //Code to send message to printer
                    break;
            }
        }
    }

    public enum LogType
    {
        Console,
        File
    }
}
