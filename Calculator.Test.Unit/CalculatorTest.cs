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
        #region addition
        // 3 tests of addition (start)

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
        public void Add_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(20, 2000);

            // Assert
            Assert.That(uut.add(20, 2000), Is.EqualTo(2020));
        }

        [Test]
        public void Add_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(123456789, 987654321);

            // Assert
            Assert.That(uut.add(123456789, 987654321), Is.EqualTo(1111111110));
        }

        // 3 tests of addition (end)
        #endregion

        #region subtraction
        // 3 tests of subtraction (start)

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

        // 3 tests of subtraction (end)
        #endregion subtraction


        #region multiplication
        // 3 tests of multiplication (start)

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

        // 3 tests of multiplication (end)
        #endregion multiplication

        #region power of
        // 3 tests of power of (start)

        [Test]
        public void power_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.power(3, 3);

            // Assert
            Assert.That(uut.power(3, 3), Is.EqualTo(27));
        }

        [Test]
        public void power_TwoNumbers_ReturnEquals()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.power(5, 4);

            // Assert
            Assert.That(uut.power(5, 4), Is.EqualTo(625));
        }

        // 3 tests of power of (end)
        #endregion power of
    }
}
