using AreaCalculatorLibrary;
using AreaCalculatorLibrary.Exceptions;
using NUnit.Framework;

namespace AreaCalculatorLibraryTests
{
    [TestFixture]
    public class CircleTests
    {
        private double delta = 1e-6;

        [Test]
        public void RadiusMustBePositive()
        {
            var exception = Assert.Throws<NegativeCircleRadiusException>(() => new Circle(-1));
        }

        [Test]
        public void CalculateArea_ResultIsCorrect()
        {
            double expectedResult = 12.5663706144;
            Circle circle = new Circle(2);
            double actualResult = circle.CalculateArea();
            Assert.AreEqual(expectedResult, actualResult, delta);
        }
    }
}
