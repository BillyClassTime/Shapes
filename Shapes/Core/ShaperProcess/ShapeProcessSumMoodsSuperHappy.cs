public class ShapeProcessSumMoodsSuperHappy : ShapeProcess
{
    public ShapeProcessSumMoodsSuperHappy(ILogger logger) : base(logger) {}

    public override double Operate(List<Shape> shapes)
    {
        Logger.Looger("Process sum moods super happy of shapes");
        if (shapes == null)
        {
            Logger.Looger("Lista de Shapes en blanco");
            return 0;
        }
        if (shapes.Count > 0)
        {
            var sum = shapes.Sum(shapeS => shapeS.Count(ShapeMoodValue.Happy));

            return sum;
        }
        return 0;
    }
}