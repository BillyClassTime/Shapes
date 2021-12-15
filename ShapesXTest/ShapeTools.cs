namespace ShapesXTest;
using Xunit;
public static class ShapeTools
{
    public static Circle CircleTest => new Circle(3);
    public static Rectangle RectangleTest => new Rectangle(3, 4);
    public static Square SquareTest => new Square(2, 2);
    public static Triangle TriangleTest => new Triangle(5, 9);
    public static ShapeNull ShapeNullTest => new ShapeNull();
    public static List<Shape> ShapeList() => new() { CircleTest, RectangleTest,SquareTest,TriangleTest };

    public static List<Shape> ListShapeCircle() => new() { CircleTest };
    public static List<Shape> ListShapeRectangle() => new() { RectangleTest };
    public static List<Shape> ListShapeSquare() => new() { SquareTest };
    public static List<Shape> ListShapeTriangle() => new() { TriangleTest };
    public static List<Shape> ListShapeEmpty() => new();
    public static List<Shape> ShapeOfTwoCircles() => new() { CircleTest, CircleTest };

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

    public static IEnumerable<object[]> DataForSumShapes =>
        new List<object[]> {
        new object[] { ListShapeEmpty(), 0D },
        new object[] { ListShapeCircle(), 28.27431D },
        new object[] { ListShapeSquare(), 4D },
        new object[] { ListShapeTriangle(), 22.5D },
        new object[] { ListShapeRectangle(), 12D },
        new object[] { ShapeList(), 66.77431D }
    };

    public static IEnumerable<object[]> DataForCornerShapes =>
    new List<object[]> {
        new object[] { ListShapeEmpty(), 0D },
        new object[] { ListShapeCircle(), 0D },
        new object[] { ListShapeSquare(), 4D },
        new object[] { ListShapeTriangle(), 3D },
        new object[] { ListShapeRectangle(), 4D },
        new object[] { ShapeList(), 11D }
    };

    public static IEnumerable<object[]> DataForNormalShapes =>
    new List<object[]> {
        new object[] { ListShapeEmpty(), 0D },
        new object[] { ListShapeCircle(), 28.27431D },
        new object[] { ListShapeSquare(), 8D },
        new object[] { ListShapeTriangle(), 25.5D },
        new object[] { ListShapeRectangle(), 16D },
        new object[] { ShapeList(), 77.77431D }
    };

    public static IEnumerable<object[]> DataForHappyShapes =>
    new List<object[]> {
        new object[] { ListShapeEmpty(), 0D },
        new object[] { ListShapeCircle(), 66.54862D },
        new object[] { ListShapeSquare(), 16D },
        new object[] { ListShapeTriangle(), 51D },
        new object[] { ListShapeRectangle(), 32D },
        new object[] { ShapeList(), 165.54862D }
    };

    public static IEnumerable<object[]> DataForSuperHappyShapes =>
    new List<object[]> {
        new object[] { ListShapeEmpty(), 0D },
        new object[] { ListShapeCircle(), 114.82293D },
        new object[] { ListShapeSquare(), 24D },
        new object[] { ListShapeTriangle(), 76.5D },
        new object[] { ListShapeRectangle(), 48D },
        new object[] { ShapeList(), 263.32293D }
    };

    public static IEnumerable<object[]> DataForShapeEngineAndFactoryShapeEmptyList =>
    new List<object[]> {
        new object[] { ListShapeEmpty(), string.Empty, ShapeEnumProcess.SumAreas, 0D },
        new object[] { ListShapeEmpty(), string.Empty, ShapeEnumProcess.SumCorners, 0D },
        new object[] { ListShapeEmpty(), string.Empty, ShapeEnumProcess.SumMoodsNormal,0D},
        new object[] { ListShapeEmpty(), string.Empty, ShapeEnumProcess.SumMoodsHappy,0D},
        new object[] { ListShapeEmpty(), string.Empty, ShapeEnumProcess.SumMoodsSuperHappy,0D}
    };

    public static IEnumerable<object[]> DataForShapeEngineWithListShape =>
    new List<object[]> {
        new object[] { ShapeList(), ListShapeStringJson(), ShapeEnumProcess.SumAreas, 66.77431D },
        new object[] { ShapeList(), ListShapeStringJson(), ShapeEnumProcess.SumCorners, 11D },
        new object[] { ShapeList(), ListShapeStringJson(), ShapeEnumProcess.SumMoodsNormal,77.77431D},
        new object[] { ShapeList(), ListShapeStringJson(), ShapeEnumProcess.SumMoodsHappy,165.54862D},
        new object[] { ShapeList(), ListShapeStringJson(), ShapeEnumProcess.SumMoodsSuperHappy,263.32293D},
    };

    public static IEnumerable<object[]> DataForFactoryShapeWithListShape =>
    new List<object[]> {
        new object[] { ShapeList(), string.Empty, ShapeEnumProcess.SumAreas, 66.77431D },
        new object[] { ShapeList(), string.Empty, ShapeEnumProcess.SumCorners, 11D },
        new object[] { ShapeList(), string.Empty, ShapeEnumProcess.SumMoodsNormal,77.77431D},
        new object[] { ShapeList(), string.Empty, ShapeEnumProcess.SumMoodsHappy,165.54862D},
        new object[] { ShapeList(), string.Empty, ShapeEnumProcess.SumMoodsSuperHappy,263.32293D},
    };

    public static IEnumerable<object[]> DataForJsonSerializerShape =>
    new List<object[]> {
        new object[] { "{}"                          , ShapeNullTest},
        new object[] { ShapeNullStringJson()         , ShapeNullTest},
        new object[] { ShapeCircleStringJson()       , CircleTest},
        new object[] { ShapeRectangleStringJson()    , RectangleTest},
        new object[] { ShapeSquareStringJson()       , SquareTest },
        new object[] { ShapeIvalidSquareStringJson() , ShapeNullTest },
        new object[] { ShapeTriangleStringJson()     , TriangleTest},
    };

    public static IEnumerable<object[]> DataForJsonDeserializerShape =>
    new List<object[]> {
        new object[] { ShapeNullStringJson()         , ShapeNullTest},
        new object[] { ShapeCircleStringJson()       , CircleTest},
        new object[] { ShapeRectangleStringJson()    , RectangleTest},
        new object[] { ShapeSquareStringJson()       , SquareTest },
        new object[] { ShapeTriangleStringJson()     , TriangleTest},
    };

    public static IEnumerable<object[]> DataForGetListShapeFromListJsonString =>
    new List<object[]> {
        new object[] { CircleTest          , ListShapeOfTwoCirclesStringJson(), ShapeOfTwoCircles()},
        new object[] { ShapeNullTest       ,"{}"                              , ListShapeEmpty() },
    };

    public static IEnumerable<object[]> DataForGetShapeFromJsonString =>
        new List<object[]>
        {
            new object[] { CircleTest   , ShapeCircleStringJson()      , CircleTest},
            new object[] { SquareTest   , ShapeSquareStringJson()      , SquareTest},
            new object[] { RectangleTest, ShapeRectangleStringJson()   , RectangleTest},
            new object[] { TriangleTest , ShapeTriangleStringJson()    , TriangleTest},
            new object[] { ShapeNullTest, ShapeIvalidSquareStringJson(), ShapeNullTest},
            new object[] { ShapeNullTest, ShapeNullStringJson()        , ShapeNullTest},
        };
}
