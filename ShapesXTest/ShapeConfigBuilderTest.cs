using Xunit;
namespace ShapesXTest;
public class ShapeConfigBuilderTest
{
    [Fact]
    public void GetValidConfigFile()
    {
        //var shapeConfigFile = "appsettings.json";
        var shapeConfig = new ShapeConfigBuilder();
        var expectedFileName = "ShapeList.json";
        Assert.Equal(expectedFileName, shapeConfig.ShapeListFileName());
    }

    [Fact]
    public void GetInvalidConfigFile()
    {
        const string invalid = "invalidappsettings.json";
        var shapeConfigFile = invalid;
        var shapeConfig = new ShapeConfigBuilder();
        shapeConfig.AppSettingName = shapeConfigFile;
        var expectedFileName = invalid;
        Assert.Equal(expectedFileName, shapeConfig.ShapeListFileName());
    }
}
