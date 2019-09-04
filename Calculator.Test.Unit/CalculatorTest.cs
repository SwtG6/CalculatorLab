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
        #region addition tests
        // 3 tests of addition (start)

        [Test]
        public void Add_TwoNumbers_ReturnEquals1()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(2, 3);

            // Assert
            Assert.That(uut.add(2,3), Is.EqualTo(5));
        }


        [Test]
        public void Add_TwoNumbers_ReturnEquals2()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(20, 2000);

            // Assert
            Assert.That(uut.add(20, 2000), Is.EqualTo(2020));
        }

        [Test]
        public void Add_TwoNumbers_ReturnEquals3()
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

        #region subtraction tests
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

        [Test]
        public void subtract_TwoNumbers_ReturnEquals2()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.subtract(2020, 2019);

            // Assert
            Assert.That(uut.subtract(2020, 2019), Is.EqualTo(1));
        }

        [Test]
        public void subtract_TwoNumbers_ReturnEquals3()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.subtract(123456789, 45678);

            // Assert
            Assert.That(uut.subtract(123456789, 45678), Is.EqualTo(123411111));
        }

        // 3 tests of subtraction (end)
        #endregion subtraction


        #region multiplication tests
        // 3 tests of multiplication (start)

        [Test]
        public void multiply_TwoNumbers_ReturnEquals1()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.multiply(2, 3);

            // Assert
            Assert.That(uut.multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void multiply_TwoNumbers_ReturnEquals2()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.multiply(12345, 876);

            // Assert
            Assert.That(uut.multiply(12345, 876), Is.EqualTo(10814220));
        }

        [Test]
        public void multiply_TwoNumbers_ReturnEquals3()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.multiply(2020, 2020);

            // Assert
            Assert.That(uut.multiply(2020, 2020), Is.EqualTo(4080400));
        }

        // 3 tests of multiplication (end)
        #endregion multiplication

        #region 'power of'tests
        // 3 tests of power of (start)

        [Test]
        public void power_TwoNumbers_ReturnEquals1()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.power(3, 3);

            // Assert
            Assert.That(uut.power(3, 3), Is.EqualTo(27));
        }

        [Test]
        public void power_TwoNumbers_ReturnEquals2()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.power(5, 4);

            // Assert
            Assert.That(uut.power(5, 4), Is.EqualTo(625));
        }

        [Test]
        public void power_TwoNumbers_ReturnEquals3()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.power(2020, 3);

            // Assert
            Assert.That(uut.power(2020, 3), Is.EqualTo(8242408000));
        }

        // 3 tests of power of (end)
        #endregion 'power of'tests
    }
}
