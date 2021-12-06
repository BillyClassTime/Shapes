public class ShapeProcessSumAreas : ShapeProcess
{
    public ShapeProcessSumAreas(ILogger logger) : base(logger)
    { }

    public override double Operate(List<Shape> shapes)
    {
        Logger.Looger("Process sum areas of shapes");
        if (shapes == null)
        {
            Logger.Looger("Lista de Shapes en blanco");
            return 0;
        }

        if (shapes.Count > 0)
        {
            var sumations = shapes.Sum(shapes => shapes.Area);
            return sumations;
        }
        return 0;
    }
}
