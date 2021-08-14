using ConsoleTestApplication;
using NUnit.Framework;
using System;

namespace MyTestProject
{
    class CalculatorTests
    {
        [Test]
        public void AddPositiveNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(1, 5);
            var expect = 6;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(-1, -5);
            var expect = -6;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddPostiveAndNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(1, -5);
            var expect = -4;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(-1, 5);
            var expect = 4;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructPosiviteNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Substruct(5,1);
            var expect = 4;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Substruct(-5, -1);
            var expect = -4;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructPostiveAndNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Substruct(5, -1);
            var expect = 6;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructNegativeAndPositiveNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Substruct(-5, 1);
            var expect = -6;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyPositiveNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(2, 4);
            var expect = 8;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(-3, -5);
            var expect = 15;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyPositiveAndNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(4, -5);
            var expect = -20;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(-2, 5);
            var expect = -10;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DividePositiveNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(8, 4);
            var expect = 2;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(-15, -5);
            var expect = 3;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(10, -2);
            var expect = -5;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(-20, 5);
            var expect = -4;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideByZero()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(20, 0));            
        }
    }
}
