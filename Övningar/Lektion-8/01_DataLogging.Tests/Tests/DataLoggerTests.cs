

using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;
using Moq;

namespace _01_DataLogging.Tests.Tests;

public class DataLoggerTests
{
    private readonly string _filePath = $"{Guid.NewGuid()}.txt";
    
    private readonly string _content = "testing";

    [Fact]
    public void Log_Should_LogMessageToLogFile()
    {
        // Arrange (SUT = System Under Test dvs det jag vill testa)
        var mockFileManager = new Mock<IFileManager>();
        IDataLogger dataLogger = new DataLogger(_filePath, mockFileManager.Object);
      //  IDataLogger sut = new DataLogger();
        // Act
        dataLogger.Log(_content);
        // Assert

        mockFileManager.Verify(fileManager => fileManager.SaveToFile(_filePath, _content), Times.Once);
    }
}
