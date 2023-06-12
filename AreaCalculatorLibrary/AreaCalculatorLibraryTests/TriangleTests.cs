using AreaCalculatorLibrary;
using AreaCalculatorLibrary.Exceptions;
using NUnit.Framework;

namespace AreaCalculatorLibraryTests
{
    [TestFixture]
    public class TriangleTests
    {
        private double delta = 1e-6;

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void SideMustBePositive(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<NegativeTriangleSideException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        public void TriangleConditionIsNotCompleted()
        {
            var exception = Assert.Throws<TriangleConditionException>(() => new Triangle(1, 2, 4));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(7, 10, 12, 34.9776714)]
        public void CalculateArea_CorrectResult(double firstSide, double secondSide, double thirdSide, double expectedResult)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            double acutalResult = triangle.CalculateArea();
            Assert.AreEqual(expectedResult, acutalResult, delta);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(6, 8, 10, true)]
        [TestCase(7, 10, 12, false)]
        public void IsTriangleRight(double firstSide, double secondSide, double thirdSide, bool expectedResult)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            bool acutalResult = triangle.IsTriangleRight;
            Assert.AreEqual(expectedResult, acutalResult);
        }
    }
}
