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

        #region division test
        // 3 tests of division (start)

        [Test]
        public void divide_TwoNumbers_ReturnEquals1()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.divide(9, 3);

            // Assert
            Assert.That(uut.divide(9, 3), Is.EqualTo(3));
        }

        [Test]
        public void divide_TwoNumbers_ReturnEquals2()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.divide(8242408000, 2020);

            // Assert
            Assert.That(uut.divide(8242408000, 2020), Is.EqualTo(4080400));
        }

        [Test]
        public void divide_TwoNumbers_ReturnEquals3()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.divide(420, 20);

            // Assert
            Assert.That(uut.divide(420, 20), Is.EqualTo(21));
        }

        [Test]
        public void divide_byZero_ThrowsException()
        {
            // Arrange
            var uut = new Calc();


            //Combined Act & Assert
            Assert.That(() => uut.divide(4, 0), Throws.TypeOf<InvalidOperationException>());
        }

        // 3 tests of division (end)
        #endregion division test

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

        #region accumulate tests
        // 3 tests of acc (start)

        [Test]
        public void accumulate_TwoNumbers_ReturnEquals1()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(10, 5);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(15));
        }

        [Test]
        public void accumulate_TwoNumbers_ReturnEquals2()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.power(2020, 3);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(8242408000));
        }

        [Test]
        public void accumulate_TwoNumbers_ReturnEquals3()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.divide(9, 3);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(3));
        }

        #endregion accumulate tests

        #region clear tests
        // 3 tests of clear (start)

        [Test]
        public void clear_Acc_ReturnEquals1()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(10, 5);
            uut.clear();

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void clear_Acc_ReturnEquals2()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.multiply(12345, 678);
            uut.clear();

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void clear_Acc_ReturnEquals3()
        {
            // Arrange
            var uut = new Calc();

            // Act
            uut.add(2020, 3);
            uut.clear();

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


        // 3 tests of clear (end)
        #endregion clear tests
    }
}
