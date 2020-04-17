using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        private IEnumerable<object> sum;

        [Theory]
        [InlineData(0, 0, 0, 0)]
#pragma warning disable xUnit1024 // Test methods cannot have overloads
        public void Add(int num1, int num2, int num3, int expected)
#pragma warning restore xUnit1024 // Test methods cannot have overloads
        {
            //Arrange
            var newInt = new UnitTests();
            //Act
            object v = Add(num1 + num2 + num3);
            object actual = v;
            //Assert
            Assert.Equal(sum, actual);
        }

#pragma warning disable xUnit1024 // Test methods cannot have overloads
        private static object Add(int v)
#pragma warning restore xUnit1024 // Test methods cannot have overloads
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(0, 0, 0)]
#pragma warning disable xUnit1024 // Test methods cannot have overloads
        public void Subtract(int minuend, int subtrhend, int expected)
#pragma warning restore xUnit1024 // Test methods cannot have overloads
        {
            //Arrange
            var newInt = new UnitTests();
            //Act
            object actual = UnitTests.Subtract(minuend - subtrhend - expected);
            //Assert
            Assert.Equal(sum, actual);
        }

#pragma warning disable xUnit1024 // Test methods cannot have overloads
        private static object Subtract(int v)
#pragma warning restore xUnit1024 // Test methods cannot have overloads
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(0, 0, 0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(0, 0, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
