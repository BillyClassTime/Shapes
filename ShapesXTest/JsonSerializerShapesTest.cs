using Xunit;
namespace ShapesXTest;
public class JsonSerializerShapesTest
{
    [Theory, MemberData(nameof(ShapeTools.DataForJsonSerializerShape), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfReturnShapesFromJsonString(string inputJson, Shape shape)
    {
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        ShapeTools.AssertShapeEqual(result, shape);
    }

    [Theory, MemberData(nameof(ShapeTools.DataForJsonDeserializerShape), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfSetShapesToString(string inputJson, Shape shape)
    {
        var deserialize = new JsonShapesSerializer();

        var result = deserialize.SetShapeToString(shape);

        var expectedDeserialization = inputJson;

        Assert.Equal(expectedDeserialization, result);
    }
}