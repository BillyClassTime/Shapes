public abstract class ShapeProcess
{
    public ILogger _logger { get; set; }

    internal ShapeProcess(ILogger logger)
    {
        _logger = logger;
    }
    public abstract double Operate(List<Shape> shapeList);
}
