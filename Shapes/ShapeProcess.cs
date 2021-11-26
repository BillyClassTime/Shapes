public abstract class ShapeProcess
{
    internal readonly ShapesEngine _engine;
    internal ConsoleLogger _logger;

    internal ShapeProcess(ShapesEngine engine, ConsoleLogger logger)
    {
        _engine = engine;
        _logger = logger;
    }
    public virtual void Operate() { }
}
