
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
    }
}
