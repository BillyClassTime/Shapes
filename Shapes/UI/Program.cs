WriteLine("Start Shapes operations");

var logger = new ConsoleLogger();

var engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ListShapesGetter(new JsonSerializerShapes()),
                    new ShapeFactory(logger)
    );
engine.Start(ShapeOperations.SumAreas);
WriteLine($"The results are: Operation:{ShapeOperations.SumAreas} - Results:{engine.ResultOperation}");

engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ListShapesGetter(new JsonSerializerShapes()),
                    new ShapeFactory(logger)
    );
engine.Start(ShapeOperations.SumCorners);
WriteLine($"The results are: Operation:{ShapeOperations.SumCorners} - Results:{engine.ResultOperation}");

engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ListShapesGetter(new JsonSerializerShapes()),
                    new ShapeFactory(logger)
    );
engine.Start(ShapeOperations.SumMoods);
WriteLine($"The results are: Operation:{ShapeOperations.SumMoods} - Results:{engine.ResultOperation}");