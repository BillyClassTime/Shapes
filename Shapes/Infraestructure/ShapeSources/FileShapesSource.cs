public class FileShapesSource : IShapeSource
{
    private readonly IShapeConfigBuilder ShapeConfigToRead;

    public FileShapesSource(IShapeConfigBuilder shapeConfigBuilder)
    {
        ShapeConfigToRead = shapeConfigBuilder;
    }
    public string GetShapesFromSource()
    {
        var shapeString = string.Empty;
        try
        {
            shapeString = File.ReadAllText(ShapeConfigToRead.ShapeListFileName());
        }
        catch
        {
            shapeString = "{}";
        }
        return shapeString;
    }
}