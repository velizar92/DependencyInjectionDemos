using System;

namespace ServerLogging.Tight_Coupling
{
    /*Here our class is tight coupled to ConsoleLogger and cannot work with
     * anything else. If we want to change the logger, we have to change the Server class
     * in compile time and to place another logger. This is BAD approach.
     */
    public class Server
    {
        private ConsoleLogger _logger;

        public Server()
        {
            _logger = new ConsoleLogger();
        }

        public void Start()
        {
            _logger.Log("Server is started.");
        }
    }
}
