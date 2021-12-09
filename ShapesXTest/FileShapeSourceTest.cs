using Xunit;
namespace ShapesXTest;
public class FileShapeSourceTest
{
    [Fact]
    public void GetValidStringShape()
    {
        var shapeConfig = new FakeShapeConfigBuilder();
        shapeConfig.ShapeListFile = "ShapeList.json";
        var shapeFileSource = new FileShapesSource(shapeConfig);
        var stringFile = shapeFileSource.GetShapesFromSource();
        var expectedContent = ShapeTools.ListShapeStringJson();
        stringFile = stringFile.Replace("\r\n", string.Empty);
        expectedContent = expectedContent.Replace("\r\n", string.Empty);
        stringFile = stringFile.Replace("\n", string.Empty);
        expectedContent = expectedContent.Replace("\n", string.Empty);
        Assert.Equal(expectedContent,stringFile);
    }

    [Fact]
    public void GetInvalidStringShape()
    {
        var shapeConfig = new FakeShapeConfigBuilder();
        shapeConfig.ShapeListFile = "non-existent.json";
        var shapeFileSource = new FileShapesSource(shapeConfig);
        var stringFile = shapeFileSource.GetShapesFromSource();
        var expectedContent = "{}";
        Assert.Equal(expectedContent, stringFile);
    }
}
