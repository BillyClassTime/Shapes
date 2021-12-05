public class ShapeProcessSumMoods : ShapeProcess
{
    public ShapeProcessSumMoods(ILogger logger, ShapeMoodValue mood) : base
    (logger)
    {
        Mood = mood;
    }
    public ShapeMoodValue Mood { get; }

    public override double Operate(List<Shape> shapes)
    {
        _logger.Looger("Process sum moods of shapes");
        if (shapes == null)
            _logger.Looger("Lista de Shapes en blanco");
        if (shapes.Count > 0)
        {
            var sum = shapes.Sum(shapeS => shapeS.Count(Mood));

            return sum;
        }
        return 0;
    }
}
