public class UnknownShapeProcess : ShapeProcess
{
    public UnknownShapeProcess(ShapesEngine engine, ConsoleLogger logger) : base(engine, logger) { }

    public override void Operate()
    {
        _logger.Looger("Unknown Shape Process"); 
    }
}
