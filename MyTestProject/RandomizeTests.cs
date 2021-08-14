using ConsoleTestApplication;
using Moq;
using NUnit.Framework;
using System;
using System.Linq;

namespace MyTestProject
{
    class RandomizeTests
    {
        [Test]
        public void CreatObject()
        {
            var random = new Random();
            var randomize = new Randomize(random);

            Assert.IsTrue(randomize._random == random);
        }

        [Test]
        public void RandomizeNumberPostive()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomNumber(-100, 100);

            Assert.IsTrue(actual >= -100 && actual < 100);
        }

        [Test]
        public void RandomizeWrongRange()
        {
            var randomize = new Randomize(new Random());

            Assert.Throws<Exception>(() => randomize.RandomNumber(100, -100));
        }

        [Test]
        public void RandomStringLowerCharacters()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomString(2, true);

            Assert.IsTrue(actual.Length == 2 && actual.All(char.IsLower));
        }

        [Test]
        public void RandomStringUpperCharacters()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomString(3, false);

            Assert.IsTrue(actual.Length == 3 && actual.All(char.IsUpper));
        }

        [Test]
        public void PasswordWithNumber()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomPassword(true, false, 0, 0);

            Assert.IsTrue(actual.Length == 1 && actual.All(char.IsDigit));
        }

        [Test]
        public void PasswordWithSpecialCharacter()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomPassword(false, true, 0, 0);

            Assert.IsTrue(actual.Length == 1 && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void PasswordWithSmallLetters()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomPassword(false, false, 5, 0);

            Assert.IsTrue(actual.Length == 5 && actual.All(char.IsLower));
        }

        [Test]
        public void PasswordWithUpperLetters()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomPassword(false, false, 0, 8);

            Assert.IsTrue(actual.Length == 8 && actual.All(char.IsUpper));
        }

        [Test]
        public void PasswordWithUpperLettersAndSpecialCharacters()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomPassword(false, true, 0, 8);

            Assert.IsTrue(actual.Length == 9 && actual.Any(char.IsUpper) && !actual.All(char.IsLetterOrDigit) && !actual.All(char.IsLower) && !actual.All(char.IsDigit)); //all zamiast any- !actual.All(char.IsLetterOrDigit)
        }

        [Test]
        public void PasswordWithSmallLettersAndNumbers()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomPassword(true, false, 5, 0);

            Assert.IsTrue(actual.Length == 6 && actual.Any(char.IsLower) && actual.Any(char.IsDigit) && !actual.Any(char.IsUpper) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void PasswordWithSmallBigSpecialCharactersNumbers()
        {
            var randomize = new Randomize(new Random());
            var actual = randomize.RandomPassword(true, true, 4, 2);

            Assert.IsTrue(actual.Length == 8 && actual.Any(char.IsLower) && actual.Any(char.IsDigit) && actual.Any(char.IsUpper) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CreateObjectCalc()
        {

            var mock = new Mock<IRandomize>();
            var calc = new Calc(1, 2, 3, 4, mock.Object, mock.Object);

            Assert.IsInstanceOf(typeof(Calc), calc);
        }

        [Test]
        public void AddPositiveNumber()
        {
            var mockAddNumber1 = new Mock<IRandomize>();
            var mockAddNumber2 = new Mock<IRandomize>();

            mockAddNumber1.Setup(ma => ma.RandomNumber(1, 10)).Returns(5);
            mockAddNumber2.Setup(ma => ma.RandomNumber(11, 20)).Returns(12);

            var calc = new Calc(1, 10, 11, 20, mockAddNumber1.Object, mockAddNumber2.Object);
            var actual = calc.Add();
            var expect = 17;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void AddNegativeNumber()
        {
            var mockAddNumber1 = new Mock<IRandomize>();
            var mockAddNumber2 = new Mock<IRandomize>();

            mockAddNumber1.Setup(ma => ma.RandomNumber(-10, -1)).Returns(-2);
            mockAddNumber2.Setup(ma => ma.RandomNumber(-20, -11)).Returns(-15);

            var calc = new Calc(-10, -1, -20, -11, mockAddNumber1.Object, mockAddNumber2.Object);
            var actual = calc.Add();
            var expect = -17;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void MultiplyPositiveNumber()
        {
            var mockAddNumber1 = new Mock<IRandomize>();
            var mockAddNumber2 = new Mock<IRandomize>();

            mockAddNumber1.Setup(ma => ma.RandomNumber(2, 5)).Returns(2);
            mockAddNumber2.Setup(ma => ma.RandomNumber(8, 100)).Returns(8);

            var calc = new Calc(2, 5, 8, 100, mockAddNumber1.Object, mockAddNumber2.Object);
            var actual = calc.Multiply();
            var expect = 16;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void MultiplyNegativeAndPositiveNumber()
        {
            var mockAddNumber1 = new Mock<IRandomize>();
            var mockAddNumber2 = new Mock<IRandomize>();

            mockAddNumber1.Setup(ma => ma.RandomNumber(1, 5)).Returns(2);
            mockAddNumber2.Setup(ma => ma.RandomNumber(-100, -8)).Returns(-9);

            var calc = new Calc(1, 5, -100, -8, mockAddNumber1.Object, mockAddNumber2.Object);
            var actual = calc.Multiply();
            var expect = -18;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void MultiplyNegativeNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(ma => ma.RandomNumber(-5, -2)).Returns(-2);
            mock2.Setup(ma => ma.RandomNumber(-100, -8)).Returns(-9);

            var calc = new Calc(-5, -2, -100, -8, mock1.Object, mock2.Object);
            var actual = calc.Multiply();
            var expect = 18;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void SubstructPositiveNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(ma => ma.RandomNumber(2, 11)).Returns(10);
            mock2.Setup(ma => ma.RandomNumber(1, 5)).Returns(2);

            var calc = new Calc(2, 11, 1, 5, mock1.Object, mock2.Object);
            var actual = calc.Substruct();
            var expect = 8;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void SubstructNegativeNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(ma => ma.RandomNumber(-2, -11)).Returns(-10);
            mock2.Setup(ma => ma.RandomNumber(-1, -5)).Returns(-2);

            var calc = new Calc(-2, -11, -1, -5, mock1.Object, mock2.Object);
            var actual = calc.Substruct();
            var expect = -8;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void SubstructPositiveAndNegativeNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(ma => ma.RandomNumber(2, 11)).Returns(10);
            mock2.Setup(ma => ma.RandomNumber(-1, -5)).Returns(-2);

            var calc = new Calc(2, 11, -1, -5, mock1.Object, mock2.Object);
            var actual = calc.Substruct();
            var expect = 12;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void DividePositiveNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(ma => ma.RandomNumber(2, 11)).Returns(10);
            mock2.Setup(ma => ma.RandomNumber(1, 5)).Returns(2);

            var calc = new Calc(2, 11, 1, 5, mock1.Object, mock2.Object);
            var actual = calc.Divide();
            var expect = 5;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void DividePositveAndNegativeNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(ma => ma.RandomNumber(2, 11)).Returns(10);
            mock2.Setup(ma => ma.RandomNumber(-1, -5)).Returns(-2);

            var calc = new Calc(2, 11, -1, -5, mock1.Object, mock2.Object);
            var actual = calc.Divide();
            var expect = -5;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void DivideByZero()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(ma => ma.RandomNumber(2, 11)).Returns(10);
            mock2.Setup(ma => ma.RandomNumber(-5, 5)).Returns(0);

            var calc = new Calc(2, 11, -5, 5, mock1.Object, mock2.Object);


            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }


       // password zadanie 4

        [Test]
        public void CreatPassword()
        {
            var mock = new Mock<IRandomize>();
            var pass = new Pass(mock.Object, true, true, 1, 2);

            Assert.IsTrue(pass.Numbers && pass.SmallLetters == 1 && pass.BigLetters == 2 && pass.SpecialCharacter && pass._randomize == mock.Object);
        }


        //// password: 8 znaków, 1Big,1Small,1Special,1number
        ///
        [Test]
        public void CorrectPassword()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 5, 1)).Returns("mnbvc2K@");

            var pass = new Pass(mock.Object, true, true, 5, 1);

            Assert.IsTrue(pass.CheckPassword());
        }

        [Test]
        public void CorrectPasswordWithoutSpecialCharacters()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, false, 6, 1)).Returns("mnbkvc2K");

            var pass = new Pass(mock.Object, true, false, 6, 1);

            Assert.IsFalse(pass.CheckPassword());
        }

        [Test]
        public void PasswordWithoutSmallLetters()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 0, 6)).Returns("4MNBVCX@");

            var pass = new Pass(mock.Object, true, true, 0, 6);

            Assert.IsFalse(pass.CheckPassword());
        }

        [Test]
        public void PasswordWithoutBigLetters()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 6, 0)).Returns("mnbvml4@");

            var pass = new Pass(mock.Object, true, true, 6 , 0);

            Assert.IsFalse(pass.CheckPassword());
        }

        [Test]
        public void PasswordWithoutNumbers()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(false, true, 6, 1)).Returns("mnbvmlB@");

            var pass = new Pass(mock.Object, false, true, 6, 1);

            Assert.IsFalse(pass.CheckPassword());
        }

        [Test]
        public void PasswordTooShort()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 4, 1)).Returns("abcd1B@");

            var pass = new Pass(mock.Object, true, true, 4, 1);

            Assert.IsFalse(pass.CheckPassword());
        }

        [Test]
        public void PasswordCorrect()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 5, 1)).Returns("mnbvc2K@"); ;

            var pass = new Pass(mock.Object, true, true, 5, 1);

            Assert.IsTrue(pass.CheckPassword());
        }



        //zadanie 5
        [Test]
        public void CreateCode()
        {
            var code = new Code();

            Assert.IsInstanceOf(typeof(Code), code);
        }

        [Test]
        public void ESTJCheck()
        {
            var code = new Code();
            var actual = code.GenerateCode(true, true, true, true);
            var expect = "ESTJ";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void ESFPCheck()
        {
            var code = new Code();
            var actual = code.GenerateCode(true, true, false, false);
            var expect = "ESFP";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void ENTPCheck()
        {
            var code = new Code();
            var actual = code.GenerateCode(true, false, true, false);
            var expect = "ENTP";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void ISFJCheck()
        {
            var code = new Code();
            var actual = code.GenerateCode(false, true, false, true);
            var expect = "ISFJ";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void INTJCheck()
        {
            var code = new Code();
            var actual = code.GenerateCode(false, false, true, true);
            var expect = "INTJ";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void INFJCheck()
        {
            var code = new Code();
            var actual = code.GenerateCode(false, false, false, true);
            var expect = "INFJ";

            Assert.AreEqual(actual, expect);
        }
        //icode

        [Test]
        public void PersonalityCreate()
        {
            var personality = new Personality();

            Assert.IsInstanceOf(typeof(Personality), personality);
        }

        [Test]
        public void PersonalityCreateWithParameteres()
        {
            var mockCode = new Mock<ICode>();
            var personality = new Personality(mockCode.Object, true,true,true,true);

            Assert.IsTrue(personality.Extraversion && personality.Judging && personality.Sensing && personality.Thinking  && personality._code == mockCode.Object);
        }

        [Test]
        public void PersonalityESTJ()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, true)).Returns("ESTJ");

           var personality = new Personality(mock.Object,true,true,true,true);
            var actual = personality.GetPersonality();
            var expect = "Wykonawca";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void PersonalityINFP()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, false)).Returns("INFP");

            var personality = new Personality(mock.Object, false, false, false, false);
            var actual = personality.GetPersonality();
            var expect = "Pośrednik";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void PersonalityESFP()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, false)).Returns("ESFP");

            var personality = new Personality(mock.Object, true, true, false, false);
            var actual = personality.GetPersonality();
            var expect = "Animator";

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void PersonalityINTJ()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, true)).Returns("INTJ");

            var personality = new Personality(mock.Object, false, false, true, true);
            var actual = personality.GetPersonality();
            var expect = "Architekt";

            Assert.AreEqual(actual, expect);
        }
    }
}
