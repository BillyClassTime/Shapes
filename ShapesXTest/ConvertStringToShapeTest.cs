using Xunit;
namespace ShapesXTest;
public class ConvertStringToShapeTest
{
    [Fact]
    public void GetListShapeFromListJsonString()
    {
        var serializer = new FakeJsonShapesSerializer();

        serializer.ShapeObject = new Circle(3);

        var convertStringToShape = new ConvertStringToShape(serializer);


        var listOfCircles = ShapeTools.ListShapeOfTwoCirclesStringJson();
        List<Shape> shapeList = convertStringToShape.GestListShapeFromListJsonString(listOfCircles);
        var expectedList = ShapeTools.ShapeOfTwoCircles();
        Assert.NotStrictEqual(shapeList, expectedList);
    }

    [Fact]
    public void GetListShapeFromListJsonStringEmpty()
    {
        var serializer = new FakeJsonShapesSerializer();

        serializer.ShapeObject = new ShapeNull();

        var convertStringToShape = new ConvertStringToShape(serializer);


        var listOfCircles = "{}";
        List<Shape> shapeList = convertStringToShape.GestListShapeFromListJsonString(listOfCircles);
        var expectedList = new List<Shape>();
        Assert.NotStrictEqual(shapeList, expectedList);
    }

    [Fact]
    public void GetCircleFromJsonString()
    {
        var serializer = new FakeJsonShapesSerializer();
        serializer.ShapeObject = new Circle(3);
        var convertStringToShape = new ConvertStringToShape(serializer);
        var circleToSerialized = ShapeTools.ShapeCircleStringJson();
        var circle = convertStringToShape.GetShapeFromJsonString(circleToSerialized);
        var expectedList = new Circle(3);
        ShapeTools.AssertShapeEqual(expectedList, circle);
    }

    [Fact]
    public void GetInvalidShapeFromJsonString()
    {
        var serializer = new FakeJsonShapesSerializer();
        serializer.ShapeObject = new ShapeNull();
        var convertStringToShape = new ConvertStringToShape(serializer);
        var invalidShape = "{}";
        var invalidSerializedShape = convertStringToShape.GetShapeFromJsonString(invalidShape);
        var expectedList = new ShapeNull();
        ShapeTools.AssertShapeEqual(expectedList, invalidSerializedShape);
    }
}
