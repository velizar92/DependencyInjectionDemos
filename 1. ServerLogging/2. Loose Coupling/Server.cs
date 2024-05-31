using System;
using System.Reflection.PortableExecutable;

namespace ServerLogging._2._Loose_Coupling
{
    /*Now our Server class works with an abstraction via ILogger interface.
    *It is not already coupled to particular class implementation. 
    *It works with everything that implements ILogger interface.
    *This gives us great flexibility, because Server class now can have
    *a ConsoleLogger, or FileLogger or DatabaseLogger, etc. This logging 
    *options can be even changed by configuration in runtime.
    */

    public class Server
    {
        private readonly ILogger _logger;

        public Server(ILogger logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            _logger = logger;
        }

        public void Start()
        {
            _logger.Log("Server is started.");
        }
    }
}
