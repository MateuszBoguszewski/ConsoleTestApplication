using ConsoleTestApplication;
using NUnit.Framework;

namespace MyTestProject
{
    class PasswordClassTests
    {
        [Test]
        public void TooShortPassword()
        {
            var password = new PasswordClass()
            {
                MyPassword = "Milen6&"
            };
            var actual = password.CheckPassword();

            Assert.IsFalse(actual);
        }

        [Test]
        public void WithoutSmallLetterPassword()
        {
            var password = new PasswordClass()
            {
                MyPassword = "MILENA6&"
            };

            var actual = password.CheckPassword();

            Assert.IsFalse(actual);
        }

        [Test]
        public void CorrectPassword()
        {
            var password = new PasswordClass()
            {
                MyPassword = "Milena6&"
            };

            var actual = password.CheckPassword();

            Assert.IsTrue(actual);
        }

        [Test]
        public void CreatePassword()
        {
            var password = new PasswordClass()
            {
                MyPassword = "Milena6&"
            };
            Assert.IsTrue(password.MyPassword == "Milena6&");
        }
    }
}



