using System;

namespace _5._AutofacDI._2._Loose_Coupling_without_DI_Container
{
    internal class ConsoleLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
