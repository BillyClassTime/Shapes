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
    [Fact]
    public void ShapesToSumMoodsOfListToZero()
    {
        var expectedSum = 0D;
        var listShapes = new List<Shape>();
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        var resultado = shapeProcess.Operate(listShapes);
        Assert.Equal(expectedSum, resultado);
    }
    
    [Fact]
    public void SumMoodsOfCirclesSuperHappy()
    {
        var expectedSum = 114.82293D;
        List<Shape> listShape = new List<Shape> { new Circle(3) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumCornersOfSquareSuperHappy()
    {
        var expectedSum = 24D;
        List<Shape> listShape = new List<Shape> { new Square(2, 2) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfTriangleSuperHappy()
    {
        var expectedSum = 76.5D;
        List<Shape> listShape = new List<Shape> { new Triangle(5, 9) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfRectangleSuperHappy()
    {
        var expectedSum = 48D;
        List<Shape> listShape = new List<Shape> { new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfSeveralShapesSuperHappy()
    {
        var expectedSum = 263.32293D;
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsSuperHappy(logger);
        var resultado = shapeProcess.Operate(ShapeTools.ShapeList());
        Assert.Equal(expectedSum, resultado);
    }
}
