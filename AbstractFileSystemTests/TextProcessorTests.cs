using _2._AbstractFileSystem._2._Loose_Coupling;
using Moq;

namespace AbstractFileSystemTests
{
    public class TextProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [Fact]
        public void Constructor_WhenFileReaderIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            IFileReader fileReader = null;
            
            //Assert
            Assert.Throws<ArgumentNullException>(() => new TextProcessor(fileReader));
        }


        //METHODNAME_CONDITION_EXPECTATION

        [Fact]
        public void ProcessTextContent_WhenFileReaderReturns3Lines_Returns3ModifiedLines()
        {
            //Arrange
            var mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(reader => reader.ReadFileLines(It.IsAny<string>()))
                .Returns(new string[] { "Line1", "Line2", "Line3" });

            int expectedModifiedLinesCount = 3;

            var textProcessor = new TextProcessor(mockFileReader.Object);

            //Act
            var modifiedLines = textProcessor.ProcessTextContent("fakePathToFile");

            //Assert
            Assert.Equal(expectedModifiedLinesCount, modifiedLines.Count);
            Assert.Equal("Line1MODIFIED", modifiedLines[0]);
            Assert.Equal("Line2MODIFIED", modifiedLines[1]);
            Assert.Equal("Line3MODIFIED", modifiedLines[2]);
        }
    }
}