using System;

namespace _4._ClientNotifier._2._Loose_Coupling
{
    public interface INotificationChannel
    {
        void Send(string message);
    }
}
