namespace ShapesXTest;
using Xunit;
public static class ShapeTools
{
    public static List<Shape> ShapeList()
    {
        var circle = new Circle(3);
        var rectangle = new Rectangle(3, 4);
        var square = new Square(2, 2);
        var triangle = new Triangle(5, 9);

        List<Shape> listOfShapes = new()
        {
            circle,
            rectangle,
            square,
            triangle
        };
        return listOfShapes;
    }
    public static List<Shape> ShapeOfTwoCircles()
    {
        List<Shape> listOfCircles = new List<Shape> { new Circle(3),new Circle(3) };
        return listOfCircles;
    }

    public static void AssertShapeEqual(Shape result, Shape shape)
    {
        Assert.Equal(shape.Name, result.Name);
        Assert.Equal(shape.Area, result.Area);
        Assert.Equal(shape.Corners, result.Corners);
    }

    public static string ListShapeStringJson() =>
        "{\r\n  \"Shapes\": [\r\n    {\r\n      \"TypeDiscriminator\": 1,\r\n      \"Radius\": 3,\r\n      \"Name\": \"TextJson.Circle\"\r\n    },\r\n    {\r\n      \"TypeDiscriminator\": 2,\r\n      \"Length\": 3,\r\n      \"Height\": 4,\r\n      \"Name\": \"TextJson.Rectangle\"\r\n    },\r\n    {\r\n      \"TypeDiscriminator\": 3,\r\n      \"Length\": 2,\r\n      \"Height\": 2,\r\n      \"Name\": \"TextJson.Square\"\r\n    },\r\n    {\r\n      \"TypeDiscriminator\": 4,\r\n      \"Width\": 5,\r\n      \"Height\": 9,\r\n      \"Name\": \"TextJson.Triangle\"\r\n    }\r\n  ]\r\n}\r\n";

    public static string ShapeCircleStringJson() => "{\"TypeDiscriminator\":1,\"Radius\":3,\"Name\":\"Circle\"}";

    public static string ShapeRectangleStringJson() => "{\"TypeDiscriminator\":2,\"Length\":3,\"Height\":4,\"Name\":\"Rectangle\"}";

    public static string ShapeSquareStringJson() => "{\"TypeDiscriminator\":3,\"Length\":2,\"Height\":2,\"Name\":\"Square\"}";

    public static string ShapeIvalidSquareStringJson() => "{\"TypeDiscriminator\":3,\r\n      \"Length\": 3,\r\n      \"Height\": 2,\r\n      \"Name\": \"TextJson.Square\"}";

    public static string ShapeTriangleStringJson() => "{\"TypeDiscriminator\":4,\"Width\":5,\"Height\":9,\"Name\":\"Triangle\"}";

    public static string ListShapeOfTwoCirclesStringJson() =>
        "{\"Shapes\": [\r\n    {\r\n      \"TypeDiscriminator\": 1,\r\n      \"Radius\": 3,\r\n      \"Name\": \"TextJson.Circle\"\r\n    }\r\n,{\r\n      \"TypeDiscriminator\": 1,\r\n      \"Radius\": 3,\r\n      \"Name\": \"TextJson.Circle\"\r\n    }\r\n  ]}";

    public static string ShapeNullStringJson() => "{\"TypeDiscriminator\":5,\"Name\":\"ShapeNull\"}";
}
