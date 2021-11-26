using System.Collections.Generic;

public partial class ShapesEngine
{
    public ShapesEngine() {}
    public ConsoleLogger Logger { get; set; } = new ConsoleLogger();

    public ListShapesGetter ListShapes { get; set; } = new ListShapesGetter();
    public double ResultOperation { get; set; }

    public void Start(ShapeOperations operation)
    {
        Logger.Looger("Inicio de operaciones con las formas geométricas");
        // Cargar las figuras a una lista
        var listShapes = ListShapes?.GetListOfShapes(); // Si no hay formas no debería seguir adelante
        // Instanciar la Fábrica de operaciones con formas
        var shapeFactory = new ShapeFactory();
        // Operar
        var ResultShapesOperations = shapeFactory.CreateOperations(operation, this);
        ResultShapesOperations?.Operate();
        // Registrar el resultado
        Logger.Looger($"El resultado de {operation} es {ResultOperation}");
    }
}