using Xunit;
namespace ShapesXTest;
public class ConvertStringToShapeTest
{
    [Theory, MemberData(nameof(ShapeTools.DataForGetListShapeFromListJsonString), MemberType = typeof(ShapeTools))]
    public void GetListShapeFromListJsonString(Shape shape, string listJsonString, List<Shape> shapeListExpected)
    {
        var serializer = new FakeJsonShapesSerializer();
        serializer.ShapeObject = shape;
        var convertStringToShape = new ConvertStringToShape(serializer);
        var listOfShapes = listJsonString;
        List<Shape> shapeList = convertStringToShape.GestListShapeFromListJsonString(listOfShapes);
        var expectedList = shapeListExpected;
        Assert.NotStrictEqual(shapeList, expectedList);
    }

    [Theory, MemberData(nameof(ShapeTools.DataForGetShapeFromJsonString), MemberType = typeof(ShapeTools))]
    public void GetCircleFromJsonString(Shape shape, string shapeToSerialized, Shape shapeExpected)
    {
        var serializer = new FakeJsonShapesSerializer();
        serializer.ShapeObject = shape;
        var convertStringToShape = new ConvertStringToShape(serializer);
        var shapeConverted = convertStringToShape.GetShapeFromJsonString(shapeToSerialized);
        ShapeTools.AssertShapeEqual(shapeExpected, shapeConverted);
    }

}
