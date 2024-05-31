using System;

namespace _5._AutofacDI._2._Loose_Coupling_without_DI_Container
{
    public class EmailService : IEmailService
    {
        private readonly ISMTPService _smtpService;

        public EmailService(ISMTPService smtpService)
        {
            _smtpService = smtpService;    
        }

        public void SendEmail()
        {
            _smtpService.Configure();

            //Normally is not ok to depend on Console but for the simplicity of the example...
            Console.WriteLine("Send email");
        }
    }
}
