using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    [TestClass()]
    public class OperationShapesTests
    {
        private const double areaExpected = 82.77431;
        [TestMethod()]
        public void BuildTest()
        {
            IShape squareOne = new Square(5, 4);
            IShape squareTwo = new Square(3, 4);
            IShape triangleOne = new Triangle(5, 9);
            IShape circle = new Circle(3);

            List<IShape> listOfShapes = new() { squareOne, squareTwo, triangleOne , circle };

            var sumations = listOfShapes.Sum(shapes => shapes.Area);

            Assert.AreEqual(areaExpected, sumations);

        }
    }
}