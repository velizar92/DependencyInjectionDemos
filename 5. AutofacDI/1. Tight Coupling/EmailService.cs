using System;

namespace _5._AutofacDI._1._Tight_Coupling
{
    public class EmailService
    {
        private readonly SMTPService _smtpService;
        public EmailService()
        {
            _smtpService = new SMTPService();
        }
        public void SendEmail()
        {
            _smtpService.Configure();
            //Normally is not ok to depend on Console but for the simplicity of the example...
            Console.WriteLine("Send email"); 
        }
    }
}
