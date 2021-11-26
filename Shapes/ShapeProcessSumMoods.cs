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
        if (_engine.ListShapes.Shapes == null)
        {
            _logger.Looger("Lista de Shapes en blanco");
            _engine.ResultOperation = 0;
        }
        double sumations = 0;
        if (_engine.ListShapes.Shapes.Count > 0)
        {
            foreach (var shape in _engine.ListShapes.Shapes)
            {
                sumations += (shape).Count(Mood);
            }
            _engine.ResultOperation = sumations;
        }
    }
}
