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
    [Fact]
    public void ShapesToSumCornesOfListToZero()
    {
        var expectedSum = 0;
        var listShapes = new List<Shape>();
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        var resultado = shapeProcess.Operate(listShapes);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumCornesOfCircles()
    {
        var expectedSum = 0;
        List<Shape> listShape = new List<Shape> { new Circle(3) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumCornersOfSquare()
    {
        var expectedSum = 4;
        List<Shape> listShape = new List<Shape> { new Square(2, 2) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumCornesOfTriangle()
    {
        var expectedSum = 3;
        List<Shape> listShape = new List<Shape> { new Triangle(5, 9) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumCornesOfRectangle()
    {
        var expectedSum = 4;
        List<Shape> listShape = new List<Shape> { new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumCornersOfSeveralsShapes()
    {
        var expectedSum = 11;
        var listShape = new List<Shape> { new Circle(3), new Square(2, 2), new Triangle(5, 9), new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumCorners(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}
