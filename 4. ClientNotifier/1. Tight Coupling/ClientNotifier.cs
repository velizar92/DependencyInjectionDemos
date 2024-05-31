using System;

namespace _4._ClientNotifier._1._Tight_Coupling
{
    /*Here our class ClientNotifier is directly coupled to the 3 service classes. This is bad!
    *It is not easily testable with unit tests! The class will be always changed when
    *we have to add additional communication service. This is not a good practice and violates
    *the Open/Close principle from SOLID. We can introduce a bug as well (very possible). 
    */
  
    public class ClientNotifier
    {
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;
        private readonly ChatService _chatService;

        public ClientNotifier()
        {
            _emailService = new EmailService();
            _smsService = new SmsService();
            _chatService = new ChatService();
        }

        public void NotifyClient()
        {
            _emailService.SendEmail("Hello Zako!");
            _smsService.SendSms("Hello Zako!");
            _chatService.SendChatMessage("Hello Zako!");
        }
    }
}
