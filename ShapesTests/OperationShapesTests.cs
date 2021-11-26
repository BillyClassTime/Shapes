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
        private const double areaExpected = 62.5;
        private const uint cornerExpected = 15;
        private const int countsExpected = 165;

        [TestMethod()]
        public void AreaSumTest()
        {
            IShape squareOne = new Square(5, 5);
            IShape squareTwo = new Square(3, 3);
            IShape triangleOne = new Triangle(5, 9);
            //IShape circle = new Circle(3);
            IShape rectangleOne = new Rectangle(3, 2);

            List<IShape> listOfShapes = new() { squareOne, squareTwo, triangleOne, rectangleOne };

            var sumations = listOfShapes.Sum(shapes => shapes.Area);

            Assert.AreEqual(areaExpected, sumations);
        }
        [TestMethod]
        public void CornersSumTest()
        {
            IShape squareOne = new Square(5, 5);
            IShape squareTwo = new Square(3, 3);
            IShape triangleOne = new Triangle(5, 9);
            //IShape circle = new Circle(3);
            IShape rectangleOne = new Rectangle(3, 2);

            List<IShape> listOfShapes = new() { squareOne, squareTwo, triangleOne, rectangleOne };

            var sumOfCorners = listOfShapes.Sum(shapes => shapes.Corners);

            Assert.AreEqual(cornerExpected, (uint)sumOfCorners);
        }

        [TestMethod]
        public void MoodTest()
        {
            ShameWithMood squareOne = new() { 
                Shape = new Square(2, 2), 
                ShapeCount = (int)new Square(2,2).Count(ShapeMoodValue.Happy) };
            //ShameWithMood squareTwo = new() { 
            //    Shape = new Square(3, 3), 
            //    ShapeCount = (int)new Square(3,3).Count(ShapeMoodValue.SupperHappy) };
            ShameWithMood triangleOne = new() { 
                Shape = new Triangle(5, 9), 
                ShapeCount = (int)new Triangle(5, 9).Count(ShapeMoodValue.Happy) };
            ShameWithMood rectangleOne = new() { 
                Shape = new Rectangle(3, 4), 
                ShapeCount = (int)new Rectangle(3, 4).Count(ShapeMoodValue.Happy) };
            //ShameWithMood circle = new() { 
            //    Shape = new Circle(3), 
            //    ShapeCount = (int)new Circle(3).Count(ShapeMoodValue.Normal) };
            ShameWithMood circleHappy = new() { 
                Shape = new Circle(3), 
                ShapeCount = (int)new Circle(3).Count(ShapeMoodValue.Happy) };
            //ShameWithMood circleSupperHappy = new() { 
            //    Shape = new Circle(7), 
            //    ShapeCount = (int)new Circle(7).Count(ShapeMoodValue.SupperHappy) };

            List<ShameWithMood> listOfShapes = new()
            {
                squareOne,
                //squareTwo,
                triangleOne,
                rectangleOne,
                //circle,
                circleHappy,
                //circleSupperHappy,
            };

            var sumOfCounts = listOfShapes.Sum(lists => lists.ShapeCount);

            Assert.AreEqual(countsExpected, sumOfCounts);
        }
    }
}