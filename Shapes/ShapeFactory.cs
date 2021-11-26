public class ShapeFactory
{
    public ShapeProcess CreateOperations(ShapeOperations operation, ShapesEngine engine)
    {
        switch (operation)
        {
            case ShapeOperations.SumAreas:
                return new ShapeProcessSumAreas(engine, engine.Logger); 
            case ShapeOperations.SumCorners:
                return new ShapeProcessSumCorners(engine, engine.Logger);
            case ShapeOperations.SumMoods:
                var shapeOperation = new ShapeProcessSumMoods(engine, engine.Logger,ShapeMoodValue.Happy);
                return shapeOperation;
        }
        return null;
    }
}