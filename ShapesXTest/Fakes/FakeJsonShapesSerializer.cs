public class FakeJsonShapesSerializer : IShapeSerializer
{
    public Shape ShapeObject { get; set; }   = new ShapeNull();
    public string ShapeString { get; set; } = string.Empty;
    public Shape GetShapeFromString(string shapesJson)
    {
        return ShapeObject;
    }

    public string SetShapeToString(Shape shape)
    {
        return ShapeString;
    }
}
