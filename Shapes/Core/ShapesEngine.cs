﻿public partial class ShapesEngine
{
    private readonly ILogger logger;
    private readonly IShapeSource shapeSource;
    private readonly IConvertStringToShape ConvertStringToShape;
    private readonly ShapeFactory shapeFactory;

    public double ResultOperation { get; set; }

    public ShapesEngine(ILogger logger,
                        IShapeSource shapeSource,
                        IConvertStringToShape ConvertStringToShape,
                        ShapeFactory shapeFactory)
    {
        this.logger = logger;
        this.shapeSource = shapeSource;
        this.ConvertStringToShape = ConvertStringToShape;
        this.shapeFactory = shapeFactory;
    }

    public void Start(ShapeEnumProcess process)
    {
        logger.Looger("Inicio de operaciones con las formas geométricas");
        logger.Looger("Cargar las figuras a una lista");

        string shapeString = shapeSource.GetShapesFromSource();
        var shapesList = ConvertStringToShape.GestListShapeFromListJsonString(shapeString);

        var ResultShapesOperations = shapeFactory.CreateOperations(process);
        ResultOperation = ResultShapesOperations.Operate(shapesList);

        logger.Looger($"El resultado de {process} es {ResultOperation}");
        logger.Looger("Operacion completada");
    }
}