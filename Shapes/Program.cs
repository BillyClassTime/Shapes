WriteLine("Start Shapes operations");

var engine = new ShapesEngine();
engine.Start(ShapeOperations.SumAreas);

WriteLine($"The results are: Operation:{ShapeOperations.SumAreas} - Results:{engine.ResultOperation}");

engine.Start(ShapeOperations.SumCorners);

WriteLine($"The results are: Operation:{ShapeOperations.SumCorners} - Results:{engine.ResultOperation}");