using System;
using System.Collections.Generic;

namespace _4._ClientNotifier._2._Loose_Coupling
{
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
