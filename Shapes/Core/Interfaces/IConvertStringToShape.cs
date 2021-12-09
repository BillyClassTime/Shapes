public interface IConvertStringToShape
{
    public List<Shape> GestListShapeFromListJsonString(string shapeStrings);
    public Shape GetShapeFromJsonString(string shapeStrings);
}