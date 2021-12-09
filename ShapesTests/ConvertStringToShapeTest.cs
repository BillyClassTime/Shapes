using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Shapes.Tests
{
    [TestClass()]
    public class ConvertStringToShapeTest
    {
        //List<Shape> Shapes = null;
        [TestMethod()]
        public void GetListOfShapesTest()
        {
            //Done in XUnit (See the other project in this solution)
            var serializerShapes = new JsonShapesSerializer();
            var ConvertStringToShape = new ConvertStringToShape(serializerShapes);
            Assert.IsTrue(true, "TODO ListOfShapesTest");
        }
    }
}