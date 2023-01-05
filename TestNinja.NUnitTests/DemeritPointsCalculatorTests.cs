using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new DemeritPointsCalculator();
        }
        [Test]        
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(1, 0)]
        [TestCase(70, 1)]
        public void CalculateDemeritPoints_WhenCalled_ReturnsDemeritPoints(int speed, int res)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(res));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfReange_ThrowsOutOfRangException(int speed)
        {
            try
            {
                var result = _calculator.CalculateDemeritPoints(speed);
                Assert.Fail("Expected ArgumentOutOfRangeException to be thrown, but no exception was thrown.");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Do nothing - this is the expected behavior
            }
        }

    }
}
