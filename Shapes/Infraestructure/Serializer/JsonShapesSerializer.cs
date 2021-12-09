
public class JsonShapesSerializer : IShapeSerializer
{
    public Shape GetShapeFromString(string shapesJson)
    {
        if (shapesJson.Length == 0)
            return new ShapeNull();
        if (string.IsNullOrEmpty(shapesJson))
            return new ShapeNull();
        if (string.Concat(shapesJson, "U+002C").Contains("{}"))
            return new ShapeNull();
        var serializeOptions = new JsonSerializerOptions();
        serializeOptions.Converters.Add(new ShapeConverterWithTypeDiscriminator());
        try
        {
            return JsonSerializer.Deserialize<Shape>(shapesJson, serializeOptions);
        }
        catch
        {
            return new ShapeNull();
        }
    }

    public string SetShapeToString(Shape shape)
    {
        var serializeOptions = new JsonSerializerOptions();
        serializeOptions.Converters.Add(new ShapeConverterWithTypeDiscriminator());
        try
        {
            return JsonSerializer.Serialize(shape, serializeOptions);
        }
        catch
        {
            return string.Empty;
        }
    }
}