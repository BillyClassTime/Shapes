﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ListShapesGetterTests
    {
        List<Shape> Shapes = null;
        [TestMethod()]
        public void GetListOfShapesTest()
        {
            //TODO
            var serializerShapes = new JsonSerializerShapes();
            var listShapesGetter = new ListShapesGetter(serializerShapes);
            Assert.IsTrue(true,"TODO ListOfShapesTest");
        }
    }
}