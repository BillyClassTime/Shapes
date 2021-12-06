public class ShapeProcessSumMoodsNormal : ShapeProcess
{
    public ShapeProcessSumMoodsNormal(ILogger logger) : base(logger) { }

    public override double Operate(List<Shape> shapes)
    {
        Logger.Looger("Process sum moods normal of shapes");
        if (shapes == null)
        {
            Logger.Looger("Lista de Shapes en blanco");
            return 0;
        }
        if (shapes.Count > 0)
        {
            var sum = shapes.Sum(shapeS => shapeS.Count(ShapeMoodValue.Normal));

            return sum;
        }
        return 0;
    }
}
