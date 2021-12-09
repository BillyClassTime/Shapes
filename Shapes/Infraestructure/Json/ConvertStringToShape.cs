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
        JsonNode shapeNode;
        JsonArray jsonArray;
        try
        {
            shapeNode = JsonNode.Parse(shapesList);

            JsonNode root = shapeNode.Root;

            jsonArray = root["Shapes"].AsArray();
        }
        catch
        {
            jsonArray = new JsonArray();
        }
        return jsonArray;
    }


    public List<Shape> GestListShapeFromListJsonString(string shapesString)
    {
        if (!shapesString.Contains("{}"))
            foreach (var shapeString in NodeJsonStringFromShapeArray(shapesString))
            {
                var shape = GetShapeFromJsonString(shapeString);
                Shapes.Add(shape);
            }
        return Shapes;
    }

    public Shape GetShapeFromJsonString(string stringShape)
    {
        return shapeSerializer.GetShapeFromString(stringShape);
    }
}
