using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
public class JsonSerializerShapes : IShapeSerializer
{
    public Shape GetShapesFromJsonString(string shapesJson)
    {
        var serializeOptions = new JsonSerializerOptions();
        serializeOptions.Converters.Add(new ShapeConverterWithTypeDiscriminator());
        return JsonSerializer.Deserialize<Shape>(shapesJson, serializeOptions);
    }

    public string SetShapeFromStringJson(Shape shape)
    {
        var serializeOptions = new JsonSerializerOptions();
        serializeOptions.Converters.Add(new ShapeConverterWithTypeDiscriminator());
        return JsonSerializer.Serialize(shape, serializeOptions);
    }

    private JsonArray ShapeArray(string shapesList)
    {
        JsonNode shapeNode = JsonNode.Parse(shapesList);

        JsonNode root = shapeNode.Root;
        return root["Shapes"].AsArray();
    }

    public IEnumerable<string> ShapeListString(string fileShapeList)
    {
        JsonArray shapeArray = this.ShapeArray(fileShapeList);
        foreach (JsonNode shapeNode in shapeArray)
        {
            yield return shapeNode.ToString();
        }
    }
}