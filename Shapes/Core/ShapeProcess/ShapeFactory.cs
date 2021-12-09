public class ShapeFactory
{
    public ILogger Logger { get; }

    public ShapeFactory(ILogger logger)
    {
        Logger = logger;
    }

    public ShapeProcess CreateOperations(ShapeEnumProcess process)
    {
        try
        {
            string typeName = $"ShapeProcess{process}";
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