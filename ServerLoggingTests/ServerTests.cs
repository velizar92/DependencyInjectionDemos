using Moq;
using ServerLogging._2._Loose_Coupling;

namespace ServerLoggingTests
{
    public class ServerTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [Fact]
        public void Constructor_WhenLoggerIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            ILogger logger = null;

            //Assert
            Assert.Throws<ArgumentNullException>(() => new Server(logger));
        }

        //METHODNAME_CONDITION_EXPECTATION

        [Fact]
        public void Start_WhenIsCalled_LogsServerStartedMessage()
        {
            //Arrange
            var mockLogger = new Mock<ILogger>();
            var server = new Server(mockLogger.Object);

            //Act
            server.Start();

            //Assert
            mockLogger.Verify(logger => logger.Log("Server is started."), Times.Once);
        }
    }
}