

namespace _01_SaveAndReadToFromFile.Services;

internal class FileService
{
    private static readonly string filePath = @"C:\Users\jolle\OneDrive\Skrivbord\customers.json";
    private static readonly string filePath1 = @"C:\Nackademin\customers.json";
    

    public static void SaveToFile(string contentAsJson)
    {
        using var sw = new StreamWriter(filePath1);
        sw.WriteLine(contentAsJson);
    }

    public static string ReadFromFile()
    {
        if(File.Exists(filePath1)) 
        {
            using var sr = new StreamReader(filePath1);
            return sr.ReadToEnd();
        }
        return null!;
    }

}
