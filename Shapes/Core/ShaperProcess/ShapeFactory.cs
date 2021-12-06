public class ShapeFactory
{
    public ILogger Logger { get; }

    public ShapeFactory(ILogger logger)
    {
        Logger = logger;
    }

    public ShapeProcess CreateOperations(ShapeOperations operation)
    {
        try
        {
            string typeName = $"ShapeProcess{operation}";
            //if (!typeName.Contains("Moods"))
            return (ShapeProcess)Activator.CreateInstance(
                Type.GetType(typeName),
                new object[] { Logger });
        }
        catch
        {
            return new UnknownShapeProcess(Logger);
        }
    }
}