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
            /*case ShapeOperations.SumMoods:
                return new ShapeProcessSumMoods(engine, engine.Logger);*/ //ESTE CAMBIO ESTA COMPLICADO
        }
        return null;
    }

}