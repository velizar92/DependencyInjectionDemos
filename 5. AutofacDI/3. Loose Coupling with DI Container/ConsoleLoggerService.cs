using System;
using _5._AutofacDI._3._Loose_Coupling_with_DI_Container.Interfaces;

namespace _5._AutofacDI._3._Loose_Coupling_with_DI_Container
{
    internal class ConsoleLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
