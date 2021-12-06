public class UnknownShapeProcess : ShapeProcess
{
    public UnknownShapeProcess(ILogger logger) : base(logger) { }

    public override double Operate(List<Shape> shapes)
    {
        Logger.Looger("Unknown Shape Process");
        return 0;
    }
}
