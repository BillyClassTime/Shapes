public interface IShapeSerializer
{
    Shape GetShapesFromJsonString(string shapesJson);
    string SetShapeFromStringJson(Shape shape);
    IEnumerable<string> ShapeListString(string fileShapeList);
}