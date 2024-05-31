using _5._AutofacDI._1._Tight_Coupling;
using System;

namespace _5._AutofacDI._2._Loose_Coupling_without_DI_Container
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
