public class ShapesEngine
{
    public ShapesEngine() {}
    public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
    public FileShapesSource ShapesSource { get; set; } = new FileShapesSource();
    public JsonSerializerShapes SerializerShapes { get; set; } = new JsonSerializerShapes();
    public ListShapesEngine listShapes { get; set; } = new ListShapesEngine();
    public void Start(ShapeEnumsOperations operation)
    {

        Logger.Looger("Inicio de operaciones con las formas geométricas");
        // recuparar las figuras de un Json, BD o INI
        var stringShapes = ShapesSource.GetShapesFromSource();
        // Cargar las figuras a un string
        var shapesSerializer = SerializerShapes.GetShapesFromJsonString();
        // Cargar las figuras a una lista
        var listShapes = ListShapesEngine.GetListOfShapes();
        // Instanciar la Fábrica de operaciones con formas
        var shapeFactory = new ShapeFactory();
        // Operar
        var ShapesOperations = shapeFactory.CreateOperations(listShapes,operation, this);

        // Registrar el resultado
    }
}