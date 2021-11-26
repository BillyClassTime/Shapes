using System.Linq;

public class ShapeProcessSumMoods : ShapeProcess
{
    public ShapeProcessSumMoods(ShapesEngine engine, ConsoleLogger logger, ShapeMoodValue mood) : base
    (engine, logger)
    {
        Mood = mood;
    }
    public ShapeMoodValue Mood { get; }

    public override void Operate()
    {
        _logger.Looger("Process sum moods of shapes");
        var shapes = _engine.ListShapes.Shapes;
        _engine.ResultOperation = 0;
        if (shapes == null)
            _logger.Looger("Lista de Shapes en blanco");
        double sumations = 0;
        if (shapes.Count > 0)
        {
            var sum = shapes.Sum(shapeS => shapeS.Count(Mood));

            _engine.ResultOperation = sumations;
        }
    }
}
