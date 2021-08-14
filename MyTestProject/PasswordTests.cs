using ConsoleTestApplication;
using NUnit.Framework;

namespace MyTestProject
{
    class PasswordTests
    {
        [Test]
        public void TooShortPassword()
        {
            var password = new Password();
            var actual = password.CheckPassword("Milen1@");
            Assert.IsFalse(actual);
        }

        [Test]
        public void WithoutSmallLetterPassword()
        {
            var password = new Password();
            var actual = password.CheckPassword("MILENA1@");
            Assert.IsFalse(actual);
        }

        [Test]
        public void WithoutBigLetterPassword()
        {
            var password = new Password();
            var actual = password.CheckPassword("milena1@");
            Assert.IsFalse(actual);
        }

        [Test]
        public void WithoutNumberPassword()
        {
            var password = new Password();
            var actual = password.CheckPassword("Milenap@");
            Assert.IsFalse(actual);
        }

        [Test]
        public void WithoutSpecialCharacterPassword()
        {
            var password = new Password();
            var actual = password.CheckPassword("Milena1p");
            Assert.IsFalse(actual);
        }

        [Test]
        public void GoodPassword()
        {
            var password = new Password();
            var actual = password.CheckPassword("Milena1%");
            Assert.IsTrue(actual);
        }
    }
}
