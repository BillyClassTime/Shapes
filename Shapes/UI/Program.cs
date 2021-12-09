WriteLine("Start Shapes operations");

var logger = new ConsoleLogger();

var engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ConvertStringToShape(new JsonShapesSerializer()),
                    new ShapeFactory(logger)
    );
engine.Start(ShapeEnumProcess.SumAreas);
WriteLine($"The results are: Operation:{ShapeEnumProcess.SumAreas} - Results:{engine.ResultOperation}");

engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ConvertStringToShape(new JsonShapesSerializer()),
                    new ShapeFactory(logger)
    );
engine.Start(ShapeEnumProcess.SumCorners);
WriteLine($"The results are: Operation:{ShapeEnumProcess.SumCorners} - Results:{engine.ResultOperation}");

engine = new ShapesEngine(
                    logger,
                    new FileShapesSource(new ShapeConfigBuilder()),
                    new ConvertStringToShape(new JsonShapesSerializer()),
                    new ShapeFactory(logger)
    );

engine.Start(ShapeEnumProcess.SumMoodsHappy);
WriteLine($"The results are: Operation:{ShapeEnumProcess.SumMoodsHappy} - Results:{engine.ResultOperation}");