using Xunit;
namespace ShapesXTest;
public class JsonSerializerShapesTest
{
    [Fact]
    public void ReturnsDefaultPolicyFromEmptyJsonString()
    {
        var inputJson = "{}";
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        var shape = new ShapeNull();
        AssertPoliciesEqual(result, shape);
    }

    [Fact]
    public void ReturnsSimpleAutoPolicyFromValidJsonString()
    {
        var inputJson = @"{
          ""type"": ""Auto"",
          ""make"": ""BMW""
        }
        ";
        var serializer = new JsonPolicySerializer();

        var result = serializer.GetPolicyFromString(inputJson);

        var policy = new Policy
        {
            Type = "Auto",
            Make = "BMW"
        };
        AssertPoliciesEqual(result, policy);
    }

    private static void AssertPoliciesEqual(Shape result, Shape shape)
    {
        Assert.Equal(shape.Name, result.Name);
        Assert.Equal(shape.Area, result.Area);
        Assert.Equal(shape.Corners, result.Corners);
    }
}
