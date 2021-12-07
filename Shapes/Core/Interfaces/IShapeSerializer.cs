public interface IShapeSerializer
{
    Shape GetShapeFromString(string shapesJson);
    string SetShapeToString(Shape shape);
}