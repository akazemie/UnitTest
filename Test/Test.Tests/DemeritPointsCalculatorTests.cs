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
            _demeritPoints = new DemeritPointsCalculator(); ;
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsNegative_ArgumentOutofRangeException()
        {
            //Assert
            Assert.That(() => _demeritPoints.CalculateDemeritPoints(-1), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
