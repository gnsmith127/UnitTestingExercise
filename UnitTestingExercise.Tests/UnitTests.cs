using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(2,4,5,11)]
        [InlineData(0, 5,7, 12)]
        [InlineData(-3, -2, 5, 0)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 1, 4)]
        [InlineData(32, 16, 16)]
        [InlineData(6, 15, -9)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,7,21)]
        [InlineData(4,8,32)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(45, 9, 5)]
        [InlineData(36,6, 9)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsTired()
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            bool actual = test.IsTired();
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void MyName()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            string actual = test.MyName();
            //Assert
            Assert.Equal("Gianna", actual);
        }
    }
}
