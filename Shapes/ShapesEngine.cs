public partial class ShapesEngine
{
    public ShapesEngine() {}
    public ConsoleLogger Logger { get; set; } = new ConsoleLogger();

    public ListShapesGetter ListShapes { get; set; } = new ListShapesGetter();
    public double ResultOperation { get; set; }

    public void Start(ShapeOperations operation)
    {
        Logger.Looger("Inicio de operaciones con las formas geométricas");
        Logger.Looger("Cargar las figuras a una lista");

        var listShapes = ListShapes?.GetListOfShapes(); 

        var shapeFactory = new ShapeFactory();

        var ResultShapesOperations = shapeFactory.CreateOperations(operation, this);
        ResultShapesOperations.Operate();

        Logger.Looger($"El resultado de {operation} es {ResultOperation}");
        Logger.Looger("Operacion completada");
    }
}