public partial class ShapesEngine
{
    private readonly ILogger logger;
    private readonly IShapeSource shapeSource;
    private readonly ListShapesGetter listShapesGetter;
    private readonly ShapeFactory shapeFactory;

    public double ResultOperation { get; set; }

    public ShapesEngine(ILogger logger,
                        IShapeSource shapeSource,
                        ListShapesGetter listShapesGetter,
                        ShapeFactory shapeFactory)
    {
        this.logger = logger;
        this.shapeSource = shapeSource;
        this.listShapesGetter = listShapesGetter;
        this.shapeFactory = shapeFactory;
    }

    public void Start(ShapeOperations operation)
    {
        logger.Looger("Inicio de operaciones con las formas geométricas");
        logger.Looger("Cargar las figuras a una lista");

        string shapeString = shapeSource.GetShapesFromSource();

        var shapesList = listShapesGetter.GetListOfShapes(shapeString);

        var ResultShapesOperations = shapeFactory.CreateOperations(operation);
        ResultOperation = ResultShapesOperations.Operate(shapesList);

        logger.Looger($"El resultado de {operation} es {ResultOperation}");
        logger.Looger("Operacion completada");
    }
}