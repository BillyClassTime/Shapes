using Xunit;
namespace ShapesXTest;
public class ShapeFactoryTest
{
    [Fact]
    public void FactorySumAreasOperation()
    {
        var expectedSum = 66.77431D;
        var operation = ShapeOperations.SumAreas;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory  = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);
        var listShape = new List<Shape> { new Circle(3), new Square(2, 2), new Triangle(5, 9), new Rectangle(3, 4) };
        var result = ResultShapeSumAreasOperation.Operate(listShape);
        Assert.Equal(expectedSum, result);
    }
}
