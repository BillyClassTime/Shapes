public class FakeShapeConfigBuilder : IShapeConfigBuilder
{
    public string ShapeListFile { get; set; } = "ShapeList.json";
    public string AppSettingName { get; set; } = "appsettings.json";

    public string ShapeListFileName()
    {
        return ShapeListFile;
    }
}
