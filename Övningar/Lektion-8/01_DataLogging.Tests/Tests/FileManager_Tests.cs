

using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;

namespace _01_DataLogging.Tests.Tests;

public class FileManager_Tests
{
    private readonly string _realFilePath = $"{Guid.NewGuid()}.txt";
    private readonly string _fakeFilePath = @$"c:\{Guid.NewGuid()}\fakefile.txt";
    private readonly string _content = "testing";
    [Fact]
    // Integrationstest (Går mot ett annat system, såsom filsystemet på datorn)
    public void SaveToFile_Should_WriteContentToFileWhenFileExists_ThenReturnTrue()
    {
        // Arrange
        IFileManager fileManager = new FileManager();
        string filePath = $"{Guid.NewGuid()}.txt";

        //Act
        bool result = fileManager.SaveToFile(_realFilePath, "testing");
        string result_content = File.ReadAllText(_realFilePath);

        // Assert
        Assert.True(result);

        Assert.Contains(result_content.Trim(), _content);

        // Cleanup
        if (File.Exists(_realFilePath))
            File.Delete(_realFilePath);
    }

    // Unit test (testar bara själva funktionaliteten, ingen koppling till något annat system)

    [Fact]
    public void SaveToFile_Should_ReturnFalse_WhenFileNotCreated()
    {
        // Arrange
        IFileManager fileManager = new FileManager();


        // Act
        bool result = fileManager.SaveToFile(_fakeFilePath, _content);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ReadFromFile_Should_ReturnNull_WhenFileDoesNotExist()
    {
        // Arrange
        IFileManager fileManager = new FileManager();
        // Act
        string result = fileManager.RoadFromFile(_fakeFilePath);
        // Assert
        Assert.Null(result);
    }
}
