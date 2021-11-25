using System.IO;

public class FileShapesSource
{
    public string GetShapesFromSource(string fileName) => File.ReadAllText(fileName);
}