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
        shapeEngine?.Start(ShapeEnumProcess.SumAreas);
        Assert.Equal(expectedSum, shapeEngine?.ResultOperation);

    }

    [Theory, MemberData(nameof(ShapeTools.DataForShapeEngineWithListShape), MemberType = typeof(ShapeTools))]
    [MemberData(nameof(ShapeTools.DataForShapeEngineAndFactoryShapeEmptyList), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfStartWithAnyProcess(List<Shape> listShape, string listStringJson, 
                                                 ShapeEnumProcess process, double expectedSum)
    {
        shapeSource.ShapeString = listStringJson;
        convertStringToShape.Shapes = listShape;
        shapeEngine?.Start(process);
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
