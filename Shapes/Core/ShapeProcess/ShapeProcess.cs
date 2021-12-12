public abstract class ShapeProcess
{
    internal ILogger Logger { get; set; }

    internal ShapeProcess(ILogger logger)
    {
        Logger = logger;
    }
    public abstract double Operate(List<Shape> shapeList);
}
