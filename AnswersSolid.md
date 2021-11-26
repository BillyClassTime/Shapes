# Aplicando SOLID al proyecto de Shapes

Aplicado Single Responsability Principle y Open Close Principle
Falta -> LSP, ISP y DIP.

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
            foreach (var shape in _engine.ListShapes.Shapes)
            {
                sumations += (shape).Count(Mood);
            }
            _engine.ResultOperation = sumations;
        }
    }
}
```
Como podemos ver se ha extendido el constructor para que acepte el estado de animo de ls formas
y por otro lado la sumatoria de las formas se pasa a la lista recorriendola de arriba a abajo.
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
