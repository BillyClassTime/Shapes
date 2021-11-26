//using System.Linq;

//public class ShapeProcessSumMoods : ShapeProcess
//{
//    public ShapeProcessSumMoods(ShapesEngine engine, ConsoleLogger logger) : base
//    (engine, logger)
//    { }

//    public override void Operate()
//    {
//        _logger.Looger("Process sum moods of shapes");
//        if (_engine.ListShapes.Shapes == null)
//        {
//            _logger.Looger("Lista de Shapes en blanco");
//            _engine.ResultOperation = 0;
//        }

//        if (_engine.ListShapes.Shapes.Count > 0)
//        {
//            var sumations = _engine.ListShapes.Shapes.Sum(shapes => shapes.Moods);
//            _engine.ResultOperation = sumations;
//        }
//    }
//}
