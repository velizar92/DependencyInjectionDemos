using System;

namespace _5._AutofacDI._1._Tight_Coupling
{
    public class SMTPService
    {
        private readonly TCPPacketController _tcpPacketController;
        public SMTPService()
        {
            _tcpPacketController = new TCPPacketController();
        }
        public void Configure()
        {
            _tcpPacketController.ConfigureController();
            Console.WriteLine("SMTP Configured");
        }
    }
}
