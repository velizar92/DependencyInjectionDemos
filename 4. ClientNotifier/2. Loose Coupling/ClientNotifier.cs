using System;
using System.Collections.Generic;

namespace _4._ClientNotifier._2._Loose_Coupling
{
    /*Here our class ClientNotifier is totally decoupled from concrete implementations.
    *It relays on interface and can register any service that cover the INotificationChannel interface.
    *The solution is very flexible and is in sync with Open/Close principle from SOLID. If now
    *we add a new notification service this class will be not touched at all.
    */
    public class ClientNotifier
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public ClientNotifier()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void AddNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannels.Add(notificationChannel);
        }
       
        public void NotifyClient()
        {
            foreach (var notificationChannel in _notificationChannels)
            {
                notificationChannel.Send("Hello Zako!");
            }
        }
    }
}
