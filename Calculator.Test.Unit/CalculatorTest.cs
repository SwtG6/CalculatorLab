using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(2, 3);

            // Assert
            Assert.That(uut.add(2,3), Is.EqualTo(5));
        }

        [Test]
        public void subtract_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.subtract(5, 3);

            // Assert
            Assert.That(uut.subtract(5, 3), Is.EqualTo(2));
        }

        [Test]
        public void multiply_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.multiply(2, 3);

            // Assert
            Assert.That(uut.multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void power_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.power(3, 3);

            // Assert
            Assert.That(uut.power(3, 3), Is.EqualTo(9));
        }
    }
}
