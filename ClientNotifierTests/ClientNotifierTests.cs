using Moq;
using _4._ClientNotifier._2._Loose_Coupling;

namespace ClientNotifierTests
{
    public class ClientNotifierTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [Fact]
        public void NotifyClient_WhenCalled_ShouldSendNotification()
        {
            //Arrange
            var notificationChannelMock = new Mock<INotificationChannel>();
            var clientNotifier = new ClientNotifier();
            clientNotifier.AddNotificationChannel(notificationChannelMock.Object);

            //Act
            clientNotifier.NotifyClient();

            //Assert
            notificationChannelMock.Verify(x => x.Send("Hello Zako!"), Times.Once);
        }

    }
}