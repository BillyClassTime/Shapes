public class FakeConvertStringToShape : IConvertStringToShape
{
    public Shape Shape { get; set; } = new ShapeNull();
    public List<Shape> Shapes { get; set; } = new List<Shape>();

    public List<Shape> GestListShapeFromListJsonString(string shapeStrings)
    {
        return Shapes;
    }

    public Shape GetShapeFromJsonString(string shapeStrings)
    {
        return this.Shape;
    }
}
