public class ShapeFactory
{
    public ShapeProcess CreateOperations(ShapeOperations operation, ShapesEngine engine)
    {
        try
        {
            string typeName = $"ShapeProcess{operation}";
            if (!typeName.Contains("Moods"))
                return (ShapeProcess)Activator.CreateInstance(
                    Type.GetType(typeName),
                    new object[] { engine, engine.Logger });
            else
                return new ShapeProcessSumMoods(engine, engine.Logger, ShapeMoodValue.Happy);
        }
        catch
        {
            return null;
        }
    }
}