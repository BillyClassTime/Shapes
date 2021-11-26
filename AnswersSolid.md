# Aplicando SOLID al proyecto de Shapes

Aplicado Single Responsability Principle y Open Close Principle
Falta -> ISP y DIP.

## Aplicando SOLID

Contar Areas

Contar Esquinas

Contar EstadosDeAnimoDelasFormas // Bit complicate!!

Motor de las formas (ShapeEngine)
Tendrá:
Un Logger
Un creador de la lista de formas
Recuperador del fichero en disco (json) con la lista de formas a crear
Deserializar la jerarquia de clases (JSON con deserialización de polimorfismos)
Una Factoria, para que podamos pasar la lista de formas y realizar las operaciones

El motor de las formas debe tener una colección o lista de formas

El motor de formas debe llamar a la factoría para
 1 - Contar Areas
 2 - Contar Esquinas
 3 - Contar los estados de animo

El último proceso el 3 debera pernsarse con mas cuidado.

Lo he resuelto con la clase Operacion de estados de animo de formas:
ShapeProcessSumMoods:

```c#
public class ShapeProcessSumMoods : ShapeProcess
{
    public ShapeProcessSumMoods(ShapesEngine engine, ConsoleLogger logger, ShapeMoodValue mood) : base
    (engine, logger)
    {
        Mood = mood;
    }
    public ShapeMoodValue Mood { get; }

    public override void Operate()
    {
        _logger.Looger("Process sum moods of shapes");
        if (_engine.ListShapes.Shapes == null)
        {
            _logger.Looger("Lista de Shapes en blanco");
            _engine.ResultOperation = 0;
        }
        double sumations = 0;
        if (_engine.ListShapes.Shapes.Count > 0)
        {
	    var sum = shapes.Sum(shapeS => shapeS.Count(Mood));
            _engine.ResultOperation = sum;
        }
    }
}
```
Como podemos ver se ha extendido el constructor para que acepte el estado de animo de ls formas
y por otro lado la sumatoria es el resultdo de llamar a la construcción LINQ con Sum(shapeS => shapeS.Count(Mood)
Esto logra extender el proyecto para que acepte esta funcionalidad sin tocar nada de lo anterirmente realizado.

En la clase de factoria de formas se ha modificado el método así:
```c#
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
```
Se pasa lo que a los otros métodos añadiendo el estado de animo a proponer a las formas.

## LSP con el patron de objeto null

Hemos intentando no violar el LSP, siguiendo las recomendaciones de DIGA en cambio de PREGUNTE, aunque el cambio del processo de sumas según el estado de animo de formas ha impactado en nuestro código. Hemos incluido el siguiente codigo para continuar aplicando SOLID a nuestro proyecto:

```c#
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
            return new UnknownShapeProcess(engine, engine.Logger);
        }
    }
}
```
La clase ShapeEngine, ahora llamará al metodo CreateOperations de la clase fabrica de formas sin importar que devuelva un null o no.
```c#
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
```
