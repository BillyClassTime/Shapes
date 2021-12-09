public class FakeShapesSource : IShapeSource
{
    public string ShapeString { get; set; } = string.Empty;
    public string GetShapesFromSource()
    {
        return ShapeString;
    }
}
