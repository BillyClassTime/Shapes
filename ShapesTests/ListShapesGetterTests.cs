using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass()]
    public class ListShapesGetterTests
    {
        //List<Shape> Shapes = null;
        [TestMethod()]
        public void GetListOfShapesTest()
        {
            //TODO
            var serializerShapes = new JsonSerializerShapes();
            var listShapesGetter = new ListShapesGetter(serializerShapes);
            Assert.IsTrue(true, "TODO ListOfShapesTest");
        }
    }
}