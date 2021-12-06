using Xunit;
namespace ShapesXTest;
public class ShapeProcessSumAreasTest
{
    [Fact]
    public void ShapesToSumAreasOfEmptyList()
    {
        List<Shape>? listShapes = null;
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        //shapeProcess.Logger = logger;
        shapeProcess.Operate(listShapes);
        Assert.Equal("Lista de Shapes en blanco", logger.LoggerMessage.Last());
    }
    [Fact]
    public void ShapesToSumAreasOfListToZero()
    {
        var expectedSum = 0D;
        var listShapes = new List<Shape>();
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        //shapeProcess.Logger = logger;
        var resultado = shapeProcess.Operate(listShapes);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumAresOfCircles()
    {
        double expectedSum = 28.27431D;
        List<Shape> listShape = new List<Shape> { new Circle(3) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumAreasOfSquare()
    {
        double expectedSum = 4D;
        List<Shape> listShape = new List<Shape> { new Square(2,2) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumAreasOfTriangle()
    {
        double expectedSum = 22.5D;
        List<Shape> listShape = new List<Shape> { new Triangle(5, 9) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumAreasOfRectangle()
    {
        double expectedSum = 12D;
        List<Shape> listShape = new List<Shape> { new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        //shapeProcess.Logger= logger;
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
    [Fact]
    public void SumAreasOfSeveralsShapes()
    {
        double expectedSum = 66.77431D;
        var listShape = new List<Shape> { new Circle(3), new Square(2, 2), new Triangle(5, 9), new Rectangle(3, 4) };
        var logger = new FakeLogger();
        var shapeProcess = new ShapeProcessSumAreas(logger);
        var resultado = shapeProcess.Operate(listShape);
        Assert.Equal(expectedSum, resultado);
    }
}