using System;

namespace _5._AutofacDI._2._Loose_Coupling_without_DI_Container
{
    public class TCPPacketController : ITCPPacketController
    {
        public void ConfigureController()
        {
            Console.WriteLine("Controller configuring...");
        }
    }
}
