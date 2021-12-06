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
    [Fact]
    public void ShapesToSumMoodsOfListToZero()
    {
        var expectedSum = 0D;
        var listShapes = new List<Shape>();
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        shapeProcess.Logger = logger;
        var resultado = shapeProcess.Operate(listShapes);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfCirclesHappy()
    {
        var expectedSum = 66.54862D;
        List<Shape> listShape = new List<Shape> { new Circle(3) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfSquareHappy()
    {
        var expectedSum = 16D;
        List<Shape> listShape = new List<Shape> { new Square(2, 2) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfTriangleHappy()
    {
        var expectedSum = 51D;
        List<Shape> listShape = new List<Shape> { new Triangle(5, 9) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfRectangleHappy()
    {
        var expectedSum = 32D;
        List<Shape> listShape = new List<Shape> { new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumMoodsOfSeveralShapesHappy()
    {
        var expectedSum = 165.54862D;
        var listShape = new List<Shape> { new Circle(3), new Square(2, 2), new Triangle(5, 9), new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumMoodsHappy(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}