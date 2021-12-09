using Xunit;
namespace ShapesXTest;
public class JsonSerializerShapesTest
{
    [Fact]
    public void ReturnsDefaultShapeFromEmptyJsonString()
    {
        var inputJson = "{}";
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        var shape = new ShapeNull();
        ShapeTools.AssertShapeEqual(result, shape);
    }

    [Fact]
    public void ReturnsShapeNullFromNullJsonString()
    {
        var inputJson = ShapeTools.ShapeNullStringJson();
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        var shape = new ShapeNull();
        ShapeTools.AssertShapeEqual(result, shape);
    }

    [Fact]
    public void ReturnsSimpleCircleFromValidJsonString()
    {
        var inputJson = ShapeTools.ShapeCircleStringJson();
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        var circle = new Circle(3);
        ShapeTools.AssertShapeEqual(result, circle);
    }

    [Fact]
    public void ReturnsSimpleRectangleFromValidJsonString()
    {
        var inputJson = ShapeTools.ShapeRectangleStringJson();
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        var rectangle = new Rectangle(3, 4);
        ShapeTools.AssertShapeEqual(result, rectangle);
    }

    [Fact]
    public void ReturnsSimpleSquareFromValidJsonString()
    {
        var inputJson = ShapeTools.ShapeSquareStringJson();
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        var square = new Square(2,2);
        ShapeTools.AssertShapeEqual(result, square);
    }
    [Fact]
    public void ReturnsInvalidSquareFromValidJsonString()
    {
        var inputJson = ShapeTools.ShapeIvalidSquareStringJson();
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);


        var invalidSquare = new ShapeNull();
        ShapeTools.AssertShapeEqual(result, invalidSquare);
    }
    [Fact]
    public void ReturnsSimpleTriangleFromValidJsonString()
    {
        var inputJson = ShapeTools.ShapeTriangleStringJson();
        var serializer = new JsonShapesSerializer();

        var result = serializer.GetShapeFromString(inputJson);

        var triangle = new Triangle(5,9);
        ShapeTools.AssertShapeEqual(result, triangle);
    }

    [Fact]
    public void SetShapeNullToString()
    {
        var deserialize = new JsonShapesSerializer();
        var result = deserialize.SetShapeToString(new ShapeNull());
        var expectedDeserialization = ShapeTools.ShapeNullStringJson();
        Assert.Equal(expectedDeserialization, result);
    }

    [Fact]
    public void SetCircleToJsonString()
    {
        var deserialize = new JsonShapesSerializer();
        var result = deserialize.SetShapeToString(new Circle(3));
        var expectedDeserialization = ShapeTools.ShapeCircleStringJson();
        Assert.Equal(expectedDeserialization, result);
    }

    [Fact]
    public void SetRectangleToJsonString()
    {
        var deserialize = new JsonShapesSerializer();
        var result = deserialize.SetShapeToString(new Rectangle(3,4));
        var expectedDeserialization = ShapeTools.ShapeRectangleStringJson();
        Assert.Equal(expectedDeserialization, result);
    }

    [Fact]
    public void SetSquareToJsonString()
    {
        var deserialize = new JsonShapesSerializer();
        var result = deserialize.SetShapeToString(new Square(2,2));
        var expectedDeserialization = ShapeTools.ShapeSquareStringJson();
        Assert.Equal(expectedDeserialization, result);
    }

    [Fact]
    public void SetTriangleToJsonString()
    {
        var deserialize = new JsonShapesSerializer();
        var result = deserialize.SetShapeToString(new Triangle(5,9));
        var expectedDeserialization = ShapeTools.ShapeTriangleStringJson();
        Assert.Equal(expectedDeserialization, result);
    }
}
