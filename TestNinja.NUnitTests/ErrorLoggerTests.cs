
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
        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        public void Log_InvalidError_throwArgumnetNullException(string error)
        {
            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
            
            //Assert.That(() => _errorLogger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>);
        }
    }
}
