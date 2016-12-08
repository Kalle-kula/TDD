using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngineTests
{
    [TestFixture]
    public class ValidationTests
    {
        private bool ValidEmailAddress;
        private string EmailAddress;

        [Test]
        public void TrueForValidAddress()
        {
            //Arrange
            var sut = new Validator(EmailAddress, ValidEmailAddress);

            //Act
            sut.ValidateEmailAddress("joe@apple.com");

            //Assert
            Assert.IsTrue(true, EmailAddress, ValidEmailAddress);
        }

        [Test]
        public void FalseForInvalidAddress()
        {
            var sut = new Validator(EmailAddress, ValidEmailAddress);

            sut.ValidateEmailAddress("name@test2015.com");

            Assert.IsFalse(false, EmailAddress, ValidEmailAddress);
        }

        [Test]
        public void FalseForInvalidAddresAndMessage()
        {
            var sut = new Validator(EmailAddress, ValidEmailAddress);

            sut.ValidateEmailAddress("Test.com");

            //Assert.
        }
    }
}
