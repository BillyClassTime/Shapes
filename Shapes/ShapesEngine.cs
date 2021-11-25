public class ShapesEngine
{
    public ShapesEngine() {}
    public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
    
    public ListShapesGetter ListShapes { get; set; } = new ListShapesGetter();
    public void Start(ShapeOperations operation)
    {
        Logger.Looger("Inicio de operaciones con las formas geométricas");
        
        // Cargar las figuras a una lista
        var listShapes = ListShapes.GetListOfShapes();
        // Instanciar la Fábrica de operaciones con formas
        var shapeFactory = new ShapeFactory();
        // Operar
        var ShapesOperations = shapeFactory.CreateOperations(listShapes,operation, this);

        // Registrar el resultado
    }
}