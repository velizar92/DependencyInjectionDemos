using System;

namespace ServerLogging._2._Loose_Coupling
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
           //Logging to database
        }
    }
}
