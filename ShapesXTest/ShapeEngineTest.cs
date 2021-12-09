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
        //convertStringToShape.Shapes = null;
        shapeEngine?.Start(ShapeEnumProcess.SumAreas);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);

    }
    [Fact]
    public void StartSumAreasOfShapesListEmpty()
    {
        var expectedSum = 0D;
        shapeSource.ShapeString = string.Empty;
        convertStringToShape.Shapes = new List<Shape>();
        shapeEngine?.Start(ShapeEnumProcess.SumAreas);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }
    [Fact]
    public void StartSumAreasOfShapesList()
    {
        var expectedSum = 66.77431D;
        shapeSource.ShapeString = ShapeTools.ListShapeStringJson();
        convertStringToShape.Shapes = ShapeTools.ShapeList();
        shapeEngine?.Start(ShapeEnumProcess.SumAreas);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }
    [Fact]
    public void StartSumCornersOfShapesList()
    {
        var expectedSum = 11D;
        shapeSource.ShapeString = ShapeTools.ListShapeStringJson();
        convertStringToShape.Shapes = ShapeTools.ShapeList();
        shapeEngine?.Start(ShapeEnumProcess.SumCorners);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }

    [Fact]
    public void StartSumMoodsOfShapesListHappy()
    {
        var expectedSum = 165.54862D;
        shapeSource.ShapeString = ShapeTools.ListShapeStringJson();
        convertStringToShape.Shapes = ShapeTools.ShapeList();
        shapeEngine?.Start(ShapeEnumProcess.SumMoodsHappy);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }

    [Fact]
    public void StartSumMoodsOfShapesListNormal()
    {
        var expectedSum = 77.77431D;
        shapeSource.ShapeString = ShapeTools.ListShapeStringJson();
        convertStringToShape.Shapes = ShapeTools.ShapeList();
        shapeEngine?.Start(ShapeEnumProcess.SumMoodsNormal);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }

    [Fact]
    public void StartSumMoodsOfShapesListSuperHappy()
    {
        var expectedSum = 263.32293D;
        shapeSource.ShapeString = ShapeTools.ListShapeStringJson();
        convertStringToShape.Shapes = ShapeTools.ShapeList();
        shapeEngine?.Start(ShapeEnumProcess.SumMoodsSuperHappy);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);
    }
    [Fact]
    public void LogsStartingLoadingAndCompleting()
    {
        shapeSource.ShapeString = ShapeTools.ListShapeStringJson();
        convertStringToShape.Shapes = ShapeTools.ShapeList();
        shapeEngine?.Start(ShapeEnumProcess.SumCorners);

        Assert.Contains(logger.LoggerMessage, m => m == "Inicio de operaciones con las formas geométricas");
        Assert.Contains(logger.LoggerMessage, m => m == "Cargar las figuras a una lista");
        Assert.Contains(logger.LoggerMessage, m => m == "Operacion completada");
    }

   
}
