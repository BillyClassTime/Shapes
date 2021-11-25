using System.Collections.Generic;

public class ListShapesGetter
{
    public FileShapesSource ShapesSource { get; set; } = new FileShapesSource();
    public JsonSerializerShapes SerializerShapes { get; set; } = new JsonSerializerShapes();
    private List<Shape> Shapes;
    public List<Shape> GetListOfShapes()
    {
        // recuparar las figuras de un Json, BD o INI
        var stringShapes = ShapesSource.GetShapesFromSource("ShapeList.json");

        foreach (var stringShape in SerializerShapes.ShapeListString(stringShapes))
        {
            // Cargar las figuras a un string
            var shape = SerializerShapes.GetShapesFromJsonString(stringShape);
            Shapes.Add(shape);
        }

        return Shapes;
    }
}