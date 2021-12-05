public class ShapeProcessSumCorners : ShapeProcess
{
    public ShapeProcessSumCorners(ILogger logger) : base(logger)
    { }

    public override double Operate(List<Shape> shapes)
    {
        _logger.Looger("Process sum of corners' shapes");
        if (shapes == null)
        {
            _logger.Looger("Lista de Shapes en blanco");
            return 0;
        }

        if (shapes.Count > 0)
        {
            var sumations = shapes.Sum(shapes => shapes.Corners);
            return sumations;
        }
        return 0;
    }
}
