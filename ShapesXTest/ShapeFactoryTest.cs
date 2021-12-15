using Xunit;
namespace ShapesXTest;
public class ShapeFactoryTest
{
    [Theory]
    [MemberData(nameof(ShapeTools.DataForFactoryShapeWithListShape), MemberType = typeof(ShapeTools))]
    [MemberData(nameof(ShapeTools.DataForShapeEngineAndFactoryShapeEmptyList), MemberType = typeof(ShapeTools))]
    public void GeneralTestOfFactoryShapeAndOperations(List<Shape> listShape, string shapeJson, ShapeEnumProcess process,
            double expectedSum)
    {
        // shapeJson is for compatibility with set of data test
        var logger = new FakeLogger();
        ShapeFactory shapeFactory = new ShapeFactory(logger);
        var ResultShapeSumAreasOperation = shapeFactory.CreateOperations(process);
        var result = ResultShapeSumAreasOperation.Operate(listShape);
        Assert.Equal(expectedSum, result);
    }
}
