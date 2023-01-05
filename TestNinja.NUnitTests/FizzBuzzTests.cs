using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {       
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(9, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(2, "2")]
        public void GetOutput_WhenCalled_ReturnsAString(int a, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(a);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
