using ConsoleTestApplication;
using Moq;
using NUnit.Framework;

namespace MyTestProject
{
    class FizzBuzzClassTests
    {
        [Test]
        public void CheckFizzBuzzTestByCalcAdd()
        {
            //Arrange
            var mockAdd = new Mock<ICalculatorClass>();
            mockAdd.Setup(md => md.Add(10, 5)).Returns(15);

            //Act
            var fb = new FizzBuzzClass(mockAdd.Object, 10, 5);
            var actual = fb.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //Assert

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckFizzBuzzTestByCalcSubstract()
        {
            //Arrange
            var mockSubstract = new Mock<ICalculatorClass>();
            mockSubstract.Setup(md => md.Substruct(2, 4)).Returns(6);

            //Act
            var fb = new FizzBuzzClass(mockSubstract.Object, 2, 4);
            var actual = fb.CheckFizzBuzz();
            var expect = "Fizz";
            //Assert

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckFizzBuzzTestByCalcMultiply()
        {
            //Arrange
            var mockMultiply = new Mock<ICalculatorClass>();
            mockMultiply.Setup(md => md.Multiply(5, 5)).Returns(25);

            //Act
            var fb = new FizzBuzzClass(mockMultiply.Object, 5, 5);
            var actual = fb.CheckFizzBuzz();
            var expect = "Buzz";
            //Assert

            Assert.AreEqual(expect, actual);
        }
    }
}
