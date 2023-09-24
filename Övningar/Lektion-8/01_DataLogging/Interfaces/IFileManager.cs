

namespace _01_DataLogging.Interfaces;

public interface IFileManager
{
    bool SaveToFile(string filePath, string content);
    string RoadFromFile(string filePath);
}

