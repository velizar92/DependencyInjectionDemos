using System;

namespace _4._ClientNotifier._1._Tight_Coupling
{
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
