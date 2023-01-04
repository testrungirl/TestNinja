using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void canBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            Assert.That(result == true); //Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUser_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };
            //Act
            var result = reservation.CanBeCancelledBy(new User());
            //Assert
            Assert.That(result == false);


        }
    }
}