using Microsoft.Extensions.Configuration;
public class ShapeConfigBuilder : IShapeConfigBuilder
{
    public string ShapeListFile { get; set; }

    public ShapeConfigBuilder()
    {
        var config = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json", optional: false).Build();
        var section = config.GetSection(nameof(ShapeConfig));
        var shapeListConfig = section.Get<ShapeConfig>();
        ShapeListFile = shapeListConfig.ShapeListFile;
    }

}
