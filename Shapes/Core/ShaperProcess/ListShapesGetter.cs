public class ListShapesGetter
{
    private readonly IShapeSerializer shapeSerializer;

    public ListShapesGetter(IShapeSerializer shapeSerializer)
    {
        this.shapeSerializer = shapeSerializer;
    }

    private List<Shape> Shapes = new List<Shape>();

    public List<Shape> GetListOfShapes(string shapeStrings)
    {

        foreach (var shapeString in shapeSerializer.ShapeListString(shapeStrings))
        {
            // Cargar las figuras a un string
            var shape = shapeSerializer.GetShapesFromJsonString(shapeString);
            Shapes.Add(shape);
        }

        return Shapes;
    }
}