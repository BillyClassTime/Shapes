public class ShapeFactory
{
    public ILogger Logger { get; }

    public ShapeFactory(ILogger logger)
    {
        Logger = logger;
    }


    public ShapeProcess CreateOperations(ShapeOperations operation, List<Shape> shapesList)
    {
        try
        {
            string typeName = $"ShapeProcess{operation}";
            if (!typeName.Contains("Moods"))
                return (ShapeProcess)Activator.CreateInstance(
                    Type.GetType(typeName),
                    new object[] { Logger });
            else
                return new ShapeProcessSumMoods(Logger, ShapeMoodValue.Happy);
        }
        catch
        {
            return new UnknownShapeProcess(Logger);
        }
    }
}