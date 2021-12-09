using Xunit;
namespace ShapesXTest;
public class ShapeFactoryTest
{
    [Fact]
    public void FactorySumAreasOperation()
    {
        var expectedSum = 66.77431D;
        var operation = ShapeEnumProcess.SumAreas;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory  = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);
        var result = ResultShapeSumAreasOperation.Operate(ShapeTools.ShapeList());
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void FactorySumCornersOperation()
    {
        var expectedSum = 11D;
        var operation = ShapeEnumProcess.SumCorners;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);        
        var result = ResultShapeSumAreasOperation.Operate(ShapeTools.ShapeList());
        Assert.Equal(expectedSum, result);
    }
    [Fact]
    public void FactorySumMoodsNormalOperation()
    {
        var expectedSum = 77.77431D;
        var operation = ShapeEnumProcess.SumMoodsNormal;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);
        var result = ResultShapeSumAreasOperation.Operate(ShapeTools.ShapeList());
        Assert.Equal(expectedSum, result);
    }
    [Fact]
    public void FactorySumMoodsHappyOperation()
    {
        var expectedSum = 165.54862D;
        var operation = ShapeEnumProcess.SumMoodsHappy;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);        
        var result = ResultShapeSumAreasOperation.Operate(ShapeTools.ShapeList());
        Assert.Equal(expectedSum, result);
    }
    [Fact]
    public void FactorySumMoodsSuperHappyOperation()
    {
        var expectedSum = 263.32293D;
        var operation = ShapeEnumProcess.SumMoodsSuperHappy;
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(operation);        
        var result = ResultShapeSumAreasOperation.Operate(ShapeTools.ShapeList());
        Assert.Equal(expectedSum, result);
    }

}
