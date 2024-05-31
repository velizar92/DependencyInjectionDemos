using System;
using _5._AutofacDI._3._Loose_Coupling_with_DI_Container.Interfaces;

namespace _5._AutofacDI._3._Loose_Coupling_with_DI_Container
{
    public class TCPPacketController : ITCPPacketController
    {
        public void ConfigureController()
        {
            Console.WriteLine("Controller configuring...");
        }
    }
}
