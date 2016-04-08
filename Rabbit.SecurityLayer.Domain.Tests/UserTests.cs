using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rabbit.SecurityLayer.Domain.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void CanAddConfigurationFlag()
        {
            // Arrange
            var user = new User();

            // Action
            user.AddConfigurationFlag(1);

            // Assert
            Assert.AreEqual(1, user.ConfigurationFlags);
        }

        [TestMethod]
        public void CanAddConfigurationFlag_Multiple()
        {
            // Arrange
            var user = new User();

            // Action
            user.AddConfigurationFlag(1);
            user.AddConfigurationFlag(1);
            user.AddConfigurationFlag(2);

            // Assert
            Assert.AreEqual(3, user.ConfigurationFlags);
        }
    }
}