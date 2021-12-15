using Xunit;
namespace ShapesXTest;
public class ShapeProcessSumAreasTest
{
    [Fact]
    public void ShapesToSumAreasOfNullList()
    {
        List<Shape>? listShapes = null;
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        //shapeProcess.Logger = logger;
        shapeProcess.Operate(listShapes);
        Assert.Equal("Lista de Shapes en blanco", logger.LoggerMessage.Last());
    }

    [Theory,MemberData(nameof(ShapeTools.DataForSumShapes), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfSumAreas(List<Shape>? listShape, object? expectedSum)
    {
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}