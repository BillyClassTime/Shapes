public abstract class ShapeProcess
{
    public ILogger Logger { get; set; }

    internal ShapeProcess(ILogger logger)
    {
        Logger = logger;
    }
    public abstract double Operate(List<Shape> shapeList);
}
