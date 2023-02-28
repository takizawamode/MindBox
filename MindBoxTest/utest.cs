//using System;
//using NUnit.Framework;
//using ShapeLibrary;

//namespace ShapeLibrary.Tests
//{
//    public class ShapeTests
//    {
//        [Test]
//        public void Circle_ValidRadius_ReturnsCorrectArea()
//        {
//            double radius = 2;
//            Circle circle = new Circle(radius);

//            double actualArea = circle.Area();

//            double expectedArea = Math.PI * radius * radius;
//            Assert.AreEqual(expectedArea, actualArea, 0.001);
//        }

//        [Test]
//        public void Circle_NegativeRadius_ThrowsException()
//        {
//            double radius = -2;

//            Assert.Throws<ArgumentException>(() => new Circle(radius));
//        }

//        [Test]
//        public void Triangle_ValidSides_ReturnsCorrectArea()
//        {
//            double side1 = 3;
//            double side2 = 4;
//            double side3 = 5;
//            Triangle triangle = new Triangle(side1, side2, side3);

//            double actualArea = triangle.Area();

//            double s = (side1 + side2 + side3) / 2;
//            double expectedArea = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
//            Assert.AreEqual(expectedArea, actualArea, 0.001);
//        }

//        [Test]
//        public void Triangle_InvalidSides_ThrowsException()
//        {
//            double side1 = 0;
//            double side2 = 4;
//            double side3 = 5;

//            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
//        }

//        [Test]
//        public void Triangle_NotATriangle_ThrowsException()
//        {
//            double side1 = 2;
//            double side2 = 3;
//            double side3 = 6;

//            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
//        }

//        [Test]
//        public void Triangle_IsRight_ReturnsTrue()
//        {
//            double side1 = 3;
//            double side2 = 4;
//            double side3 = 5;
//            Triangle triangle = new Triangle(side1, side2, side3);

//            bool actualIsRight = triangle.IsRight();

//            Assert.IsTrue(actualIsRight);
//        }

//        [Test]
//        public void Triangle_IsNotRight_ReturnsFalse()
//        {
//            double side1 = 3;
//            double side2 = 4;
//            double side3 = 6;
//            Triangle triangle = new Triangle(side1, side2, side3);

//            bool actualIsRight = triangle.IsRight();

//            Assert.IsFalse(actualIsRight);
//        }

//        [Test]
//        public void ShapeCalculator_CalculateArea_ReturnsCorrectArea()
//        {
//            double radius = 2;
//            Circle circle = new Circle(radius);

//            double actualArea = ShapeCalculator.CalculateArea(circle);

//            double expectedArea = Math.PI * radius * radius;
//            Assert.AreEqual(expectedArea, actualArea, 0.001);
//        }
//    }
//}
