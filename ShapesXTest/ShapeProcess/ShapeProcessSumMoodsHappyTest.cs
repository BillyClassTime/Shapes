using Xunit;
namespace ShapesXTest;
public class ShapeProcessSumMoodsHappyTest
{
    [Fact]
    public void ShapesToSumMoodsOfListEmpty()
    {
        List<Shape>? listShapes = null;
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        shapeProcess.Operate(listShapes);
        Assert.Equal("Lista de Shapes en blanco", logger.LoggerMessage.Last());
    }
    
    [Theory, MemberData(nameof(ShapeTools.DataForHappyShapes), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfSumHappyShapes(List<Shape>? listShape, object? expectedSum)
    {
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}