using System;
using _5._AutofacDI._3._Loose_Coupling_with_DI_Container.Interfaces;

namespace _5._AutofacDI._3._Loose_Coupling_with_DI_Container
{
    public class SMTPService : ISMTPService
    {
        private readonly ITCPPacketController _tcpPacketController;

        public SMTPService(ITCPPacketController tcpPacketController)
        {
            _tcpPacketController = tcpPacketController;
        }
        public void Configure()
        {
            _tcpPacketController.ConfigureController();
            Console.WriteLine("SMTP Configured");
        }
    }
}
