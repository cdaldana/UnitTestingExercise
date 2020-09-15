using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
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
        [InlineData(5,5,0)]
        [InlineData(5,10,-5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();

            //Act
            var actual = test2.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4,6,24)]
        [InlineData(10,2,20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();

            //Act
            var actual = test3.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(25,5,5)]
        [InlineData(30,6,5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test4 = new UnitTestMethods();

            //Act
            var actual = test4.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetWelcome()
        {
            //Arrange
            UnitTestMethods test5 = new UnitTestMethods();

            //Act
            string actual = test5.GetWelcome();

            //Assert
            Assert.Equal("Welcome!", actual);

        }

        [Fact]
        public void YouLookSoCool()
        {
            //Arrange

           UnitTestMethods test6 = new UnitTestMethods();
            //Act
            string actual = test6.YouLookSoCool();

            //Assert
            Assert.Equal("You're Cool!", actual);
        }
    }
}
