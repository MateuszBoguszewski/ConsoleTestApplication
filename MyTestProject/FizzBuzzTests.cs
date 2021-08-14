using ConsoleTestApplication;
using NUnit.Framework;
using System;

namespace MyTestProject
{
    class FizzBuzzTests
    {
        [Test]
        public void DividePostiveNumberByThreeAndFive()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.CheckFizzBuzz(15);
            var expect = "FizzBuzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void DivideNegativeNumberByThreeAndFive()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.CheckFizzBuzz(-15);
            var expect = "FizzBuzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void DividePositiveNumberByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.CheckFizzBuzz(6);
            var expect = "Fizz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void DivideNegativeNumberByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.CheckFizzBuzz(-6);
            var expect = "Fizz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void DividePositiveNumberByFive()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.CheckFizzBuzz(10);
            var expect = "Buzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void DivideNegativeNumberByFive()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.CheckFizzBuzz(-10);
            var expect = "Buzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void NotDividePositiveNumber()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<Exception> (() =>fizzBuzz.CheckFizzBuzz(17));
        }

        [Test]
        public void NotDivideNegativeNumber()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(-19));
        }
    }
}
