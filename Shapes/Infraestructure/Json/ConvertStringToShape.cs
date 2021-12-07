public class ConvertStringToShape : IConvertStringToShape
{
    public string ShapeString { get; set; } = string.Empty;
    public List<Shape> Shapes { get; set; } = new List<Shape>();
    private readonly IShapeSerializer shapeSerializer;

    public ConvertStringToShape(IShapeSerializer shapeSerializer)
    {
        this.shapeSerializer = shapeSerializer;
    }

    private IEnumerable<string> NodeJsonStringFromShapeArray(string arrayShapeList)
    {
        JsonArray shapeArray = ShapeArray(arrayShapeList);
        foreach (JsonNode shapeNode in shapeArray)
        {
            yield return shapeNode.ToString();
        }
    } 
    private JsonArray ShapeArray(string shapesList)
    {
        JsonNode shapeNode = JsonNode.Parse(shapesList);

        JsonNode root = shapeNode.Root;
        return root["Shapes"].AsArray();
    }
   

    public List<Shape> GestListShapeFromListJsonString(string shapesString)
    {

        foreach (var shapeString in NodeJsonStringFromShapeArray(shapesString))
        {
            var shape = GestShapeFromJsonString(shapeString);
            Shapes.Add(shape);
        }

        return Shapes;
    }

    public Shape GestShapeFromJsonString(string stringShape)
    {
        return shapeSerializer.GetShapeFromString(stringShape);
    }
}
