using NUnit.Framework;
using System;

namespace Test.Tests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPoints;

        [SetUp]
        public void Setup()
        {
            _demeritPoints = new DemeritPointsCalculator();
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsNegative_ArgumentOutofRangeException()
        {
            //Assert
            Assert.That(() => _demeritPoints.CalculateDemeritPoints(-1), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(70, 1)]
        [TestCase(78, 2)]
        [TestCase(80, 3)]
        public void CalculateDemeritPoints_WhenCalled_ReturmDemeritPoint(int speedLimit, int expected)
        {
            //Act
            var result = _demeritPoints.CalculateDemeritPoints(speedLimit);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
