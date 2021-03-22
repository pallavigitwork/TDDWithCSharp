using FizzBuzz;
using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        //[InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 3, 5, 6, 10, 15, 30,31 })]
        public void ShouldExecute(int[] data)
        {
            FizzBuzzClass fbObj = new FizzBuzzClass();
            //fbObj.execute(data).Should().Be("1");
            fbObj.execute(data).Should().Be(("1,2,Fizz,Buzz,Fizz,Buzz,FizzBuzz,FizzBuzz,31"));
        }

        [Fact]
        public void shouldProcessInput()
        {
            //Arrange
            FizzBuzzClass fbObj = new FizzBuzzClass();
            //Act
            //var result = fbObj.process(num);
            // Assert
            fbObj.process(1).Should().Be("1");
            fbObj.process(3).Should().Be("Fizz");
            fbObj.process(10).Should().Be("Buzz");
            fbObj.process(15).Should().Be("FizzBuzz");
        }


            
          

    }
}
