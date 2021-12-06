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
    [Fact]
    public void ShapesToSumMoodsOfListToZero()
    {
        var expectedSum = 0D;
        var listShapes = new List<Shape>();
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        shapeProcess.Logger = logger;
        var resultado = shapeProcess.Operate(listShapes);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfCirclesNormal()
    {
        var expectedSum = 28.27431D;
        List<Shape> listShape = new List<Shape> { new Circle(3) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumCornersOfSquareNormal()
    {
        var expectedSum = 8;
        List<Shape> listShape = new List<Shape> { new Square(2, 2) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfTriangleNormal()
    {
        var expectedSum = 25.5D;
        List<Shape> listShape = new List<Shape> { new Triangle(5, 9) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfRectangleNormal()
    {
        var expectedSum = 16;
        List<Shape> listShape = new List<Shape> { new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfSeveralShapesNormal()
    {
        var expectedSum = 77.77431D;
        var listShape = new List<Shape> { new Circle(3), new Square(2, 2), new Triangle(5, 9), new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsNormal(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}
