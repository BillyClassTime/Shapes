public class FileShapesSource : IShapeSource
{
    public string GetShapesFromSource(string fileName) => File.ReadAllText(fileName);
}