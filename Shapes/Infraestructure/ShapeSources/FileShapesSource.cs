public class FileShapesSource : IShapeSource
{
    private readonly IShapeConfigBuilder ShapeConfig;

    public FileShapesSource(IShapeConfigBuilder shapeConfigBuilder)
    {
        ShapeConfig = shapeConfigBuilder;
    }
    public string GetShapesFromSource() => File.ReadAllText(ShapeConfig.ShapeListFile);
}