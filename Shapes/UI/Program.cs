WriteLine("Start Shapes operations");

var logger = new ConsoleLogger();

var engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ConvertStringToShape(new JsonShapesSerializer()),
                    new ShapeFactory(logger)
    );
engine.Start(ShapeOperations.SumAreas);
WriteLine($"The results are: Operation:{ShapeOperations.SumAreas} - Results:{engine.ResultOperation}");

engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ConvertStringToShape(new JsonShapesSerializer()),
                    new ShapeFactory(logger)
    );
engine.Start(ShapeOperations.SumCorners);
WriteLine($"The results are: Operation:{ShapeOperations.SumCorners} - Results:{engine.ResultOperation}");

engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ConvertStringToShape(new JsonShapesSerializer()),
                    new ShapeFactory(logger)
    );

engine.Start(ShapeOperations.SumMoodsHappy);
WriteLine($"The results are: Operation:{ShapeOperations.SumMoodsHappy} - Results:{engine.ResultOperation}");