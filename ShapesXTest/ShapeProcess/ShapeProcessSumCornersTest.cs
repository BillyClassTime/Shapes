using Xunit;
namespace ShapesXTest;
public class ShapeProcessSumCornersTest
{
    [Fact]
    public void ShapeToSumCornerOfEmptyList()
    {
        List<Shape>? listShapes = null;
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        shapeProcess.Operate(listShapes);
        Assert.Equal("Lista de Shapes en blanco", logger.LoggerMessage.Last());
    }

    [Theory, MemberData(nameof(ShapeTools.DataForCornerShapes), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfSumCorners(List<Shape>? listShape, object? expectedSum)
    {
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}
