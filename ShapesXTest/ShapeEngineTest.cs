using Xunit; 
namespace ShapesXTest;
public class ShapeEngineTest
{
    private ShapesEngine? shapeEngine = null;
    private readonly FakeLogger logger;
    private readonly FakeShapesSource shapeSource;
    private readonly FakeConvertStringToShape convertStringToShape;
    private readonly ShapeFactory shapeFactory;
    public ShapeEngineTest()
    {
        logger = new FakeLogger();
        shapeSource = new FakeShapesSource();
        convertStringToShape = new FakeConvertStringToShape();
        shapeFactory=new ShapeFactory(logger);

        shapeEngine = new ShapesEngine(
                                        logger,
                                        shapeSource,
                                        convertStringToShape,
                                        shapeFactory);

    }
    [Fact]
    public void ShapesToSumAreasOfNullList()
    {
        var expectedSum = 0D;
        shapeSource.ShapeString = string.Empty;
        convertStringToShape.Shapes = null;
        shapeEngine?.Start(ShapeOperations.SumAreas);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);

    }
    [Fact]
    public void StartSumAreasOfShapesListEmpty()
    {
        var expectedSum = 0D;
        shapeSource.ShapeString = string.Empty;
        convertStringToShape.Shapes = new List<Shape>();
        shapeEngine?.Start(ShapeOperations.SumAreas);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }
    [Fact]
    public void StartSumAreasOfShapesList()
    {
        var expectedSum = 66.77431D;
        shapeSource.ShapeString = listShapeStringJson();
        convertStringToShape.Shapes = shapeList();
        shapeEngine?.Start(ShapeOperations.SumAreas);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }
    [Fact]
    public void StartSumCornersOfShapesList()
    {
        var expectedSum = 11D;
        shapeSource.ShapeString = listShapeStringJson();
        convertStringToShape.Shapes = shapeList();
        shapeEngine?.Start(ShapeOperations.SumCorners);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }

    [Fact]
    public void StartSumMoodsOfShapesListHappy()
    {
        var expectedSum = 165.54862D;
        shapeSource.ShapeString = listShapeStringJson();
        convertStringToShape.Shapes = shapeList();
        shapeEngine?.Start(ShapeOperations.SumMoodsHappy);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }

    [Fact]
    public void StartSumMoodsOfShapesListNormal()
    {
        var expectedSum = 77.77431D;
        shapeSource.ShapeString = listShapeStringJson();
        convertStringToShape.Shapes = shapeList();
        shapeEngine?.Start(ShapeOperations.SumMoodsNormal);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }

    [Fact]
    public void StartSumMoodsOfShapesListSuperHappy()
    {
        var expectedSum = 263.32293D;
        shapeSource.ShapeString = listShapeStringJson();
        convertStringToShape.Shapes = shapeList();
        shapeEngine?.Start(ShapeOperations.SumMoodsSuperHappy);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }
    [Fact]
    public void LogsStartingLoadingAndCompleting()
    {
        shapeSource.ShapeString = listShapeStringJson();
        convertStringToShape.Shapes = shapeList();
        shapeEngine?.Start(ShapeOperations.SumCorners);

        Assert.Contains(logger.LoggerMessage, m => m == "Inicio de operaciones con las formas geométricas");
        Assert.Contains(logger.LoggerMessage, m => m == "Cargar las figuras a una lista");
        Assert.Contains(logger.LoggerMessage, m => m == "Operacion completada");
    }
    private string listShapeStringJson()
    {
        return "{\r\n  \"Shapes\": [\r\n    {\r\n      \"TypeDiscriminator\": 1,\r\n      \"Radius\": 3,\r\n      \"Name\": \"TextJson.Circle\"\r\n    },\r\n    {\r\n      \"TypeDiscriminator\": 2,\r\n      \"Length\": 3,\r\n      \"Height\": 4,\r\n      \"Name\": \"TextJson.Rectangle\"\r\n    },\r\n    {\r\n      \"TypeDiscriminator\": 3,\r\n      \"Length\": 2,\r\n      \"Height\": 2,\r\n      \"Name\": \"TextJson.Square\"\r\n    },\r\n    {\r\n      \"TypeDiscriminator\": 4,\r\n      \"Width\": 5,\r\n      \"Height\": 9,\r\n      \"Name\": \"TextJson.Triangle\"\r\n    }\r\n  ]\r\n}\r\n";
    }
    private List<Shape> shapeList()
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
}
