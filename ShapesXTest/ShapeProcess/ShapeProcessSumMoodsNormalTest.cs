using Xunit;
namespace ShapesXTest;
public class ShapeProcessSumMoodsNormalTest
{
    [Fact]
    public void ShapesToSumMoodsOfListEmpty()
    {
        List<Shape>? listShapes = null;
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        shapeProcess.Operate(listShapes);
        Assert.Equal("Lista de Shapes en blanco", logger.LoggerMessage.Last());
    }

    [Theory, MemberData(nameof(ShapeTools.DataForNormalShapes), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfSumNormalShapes(List<Shape>? listShape, object? expectedSum)
    {
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}
