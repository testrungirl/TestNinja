namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(6);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }

    }
}
