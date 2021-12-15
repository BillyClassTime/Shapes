using Xunit;
namespace ShapesXTest;
public class ShapeProcessSumMoodsSuperHappyTest
{
    [Fact]
    public void ShapesToSumMoodsOfListEmpty()
    {
        List<Shape>? listShapes = null;
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        shapeProcess.Operate(listShapes);
        Assert.Equal("Lista de Shapes en blanco", logger.LoggerMessage.Last());
    }
    
    [Theory, MemberData(nameof(ShapeTools.DataForSuperHappyShapes), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfSumSupperHappyShapes(List<Shape>? listShape, object? expectedSum)
    {
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}
