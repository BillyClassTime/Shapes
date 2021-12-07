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
        var listShape = shapeList();
        var result = ResultShapeSumAreasOperation.Operate(listShape);
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void FactorySumCornersOperation()
    {
        var expectedSum = 11D;
        var operation = ShapeOperations.SumCorners;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);
        var listShape = shapeList();
        var result = ResultShapeSumAreasOperation.Operate(listShape);
        Assert.Equal(expectedSum, result);
    }
    [Fact]
    public void FactorySumMoodsNormalOperation()
    {
        var expectedSum = 77.77431D;
        var operation = ShapeOperations.SumMoodsNormal;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);
        var listShape = shapeList();
        var result = ResultShapeSumAreasOperation.Operate(listShape);
        Assert.Equal(expectedSum, result);
    }
    [Fact]
    public void FactorySumMoodsHappyOperation()
    {
        var expectedSum = 165.54862D;
        var operation = ShapeOperations.SumMoodsHappy;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);
        var listShape = shapeList();
        var result = ResultShapeSumAreasOperation.Operate(listShape);
        Assert.Equal(expectedSum, result);
    }
    [Fact]
    public void FactorySumMoodsSuperHappyOperation()
    {
        var expectedSum = 263.32293D;
        var operation = ShapeOperations.SumMoodsSuperHappy;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);
        var listShape = shapeList();
        var result = ResultShapeSumAreasOperation.Operate(listShape);
        Assert.Equal(expectedSum, result);
    }
    private List<Shape> shapeList()
    {
        var circle = new Circle(3);
        var rectangle = new Rectangle(3, 4);
        var square = new Square(2, 2);
        var triangle = new Triangle(5, 9);

        List<Shape> listOfShapes = new()
        {
            circle,
            rectangle,
            square,
            triangle
        };
        return listOfShapes;
    }
}
