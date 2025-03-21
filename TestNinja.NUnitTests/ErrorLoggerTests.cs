
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        public ErrorLogger _errorLogger;
        [SetUp]
        public void SetUp() {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _errorLogger.Log("a");
            Assert.That(_errorLogger.LastError, Is.EqualTo("a"));
        }
        [Test]
#pragma warning disable NUnit1001 // The individual arguments provided by a TestCaseAttribute must match the type of the corresponding parameter of the method
        [TestCase(null)]
#pragma warning restore NUnit1001 // The individual arguments provided by a TestCaseAttribute must match the type of the corresponding parameter of the method
        [TestCase("")]
        [TestCase("  ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
        }

    }
}
