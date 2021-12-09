using Microsoft.Extensions.Configuration;
public class ShapeConfigBuilder : IShapeConfigBuilder
{
    public string AppSettingName { get; set; } = "appsettings.json";

    public string ShapeListFileName()
    {
        var shapeListFile = string.Empty;
        try
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile(AppSettingName, optional: false).Build();
            var section = config.GetSection(nameof(ShapeConfig));
            var shapeListConfig = section.Get<ShapeConfig>();
            shapeListFile = shapeListConfig.ShapeListFile;
        }
        catch
        {

            shapeListFile = "invalidappsettings.json";
        }
        return shapeListFile;

    }
}

