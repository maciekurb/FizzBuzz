using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;

        public FizzBuzzTest()
        {
            _fizzBuzz = new FizzBuzz();
        }

        public void Is_Zero_Fizz_Must_Return_False()
        {
            var result = _fizzBuzz.IsFizz(0);
            Assert.Equal(result, false);
        }
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        [InlineData(21)]
        public void Is_Fizz_Must_Return_True(int value)
        {
            var result = _fizzBuzz.IsFizz(value);
            Assert.Equal(result, true);
        }
        [Fact]
        public void Is_Five_Fizz_Must_Return_False()
        {
            var result = _fizzBuzz.IsFizz(5);
            Assert.Equal(result, false);
        }
        [Fact]
        public void Is_Ten_Buzz_Must_Return_True()
        {
            var result = _fizzBuzz.IsBuzz(10);
            Assert.Equal(result, true);
        }
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        [InlineData(75)]
        [InlineData(90)]
        public void Is_Value_FizzBuzz_Must_Return_True(int value)
        {
            var result = _fizzBuzz.IsFizzBuzz(value);
            Assert.Equal(result, true);
        }

        [Fact]
        public void Zero_Must_Return_FizzBuzz()
        {
            var result = _fizzBuzz.Go(0);
            Assert.Equal(result, "FizzBuzz");
        }

        [Fact]
        public void Three_Must_Return_Fizz()
        {
            var result = _fizzBuzz.Go(3);
            Assert.Equal(result, "Fizz");
        }
        
        [Fact]
        public void Five_Must_Return_Buzz()
        {
            var result = _fizzBuzz.Go(5);
            Assert.Equal(result, "Buzz");
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(13)]
        [InlineData(86)]
        [InlineData(1674937)]
        public void Neutral_Must_Return_Same_Value(int value)
        {
            var result = _fizzBuzz.Go(value);
            Assert.Equal(result, value.ToString());
        }
        
        [Fact]
        public void Check_Sequence()
        {
            var result = _fizzBuzz.GetSequence(5);
            string[] expectedResult = { "1", "2", "Fizz", "4", "Buzz" };
            Assert.Equal(result, expectedResult);
        }

    }
}
