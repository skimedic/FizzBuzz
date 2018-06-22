using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;
using FizzBuzzLibrary;
using Xunit;

namespace XUnitTestProject1
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(0, 3, false)]
        [InlineData(1, 3, false)]
        [InlineData(2, 3, false)]
        [InlineData(3, 3, true)]
        [InlineData(4, 3, false)]
        [InlineData(5, 3, false)]
        [InlineData(6, 3, true)]
        [InlineData(7, 3, false)]
        [InlineData(8, 3, false)]
        [InlineData(9, 3, true)]
        [InlineData(10, 3, false)]
        [InlineData(11, 3, false)]
        [InlineData(12, 3, true)]
        [InlineData(13, 3, false)]
        [InlineData(14, 3, false)]
        [InlineData(15, 3, true)]
        [InlineData(30, 3, true)]
        [InlineData(45, 3, true)]
        [InlineData(0, 5, false)]
        [InlineData(1, 5, false)]
        [InlineData(2, 5, false)]
        [InlineData(3, 5, false)]
        [InlineData(4, 5, false)]
        [InlineData(5, 5, true)]
        [InlineData(6, 5, false)]
        [InlineData(7, 5, false)]
        [InlineData(8, 5, false)]
        [InlineData(9, 5, false)]
        [InlineData(10, 5, true)]
        [InlineData(11, 5, false)]
        [InlineData(12, 5, false)]
        [InlineData(13, 5, false)]
        [InlineData(14, 5, false)]
        [InlineData(15, 5, true)]
        [InlineData(30, 5, true)]
        [InlineData(45, 5, true)]
        public void ShouldPrintFizzIfDivisibleBy(int firstNumber, int divisor, bool expected)
        {
            var sut = new FizzBuzz();
            Assert.Equal(expected, sut.CheckNumberForDivisor(firstNumber, divisor));
        }

        [Theory]
        [InlineData(10, new string[10] {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"})]
        public void ShouldTestFizzBuzzResults(int max, string[] expected)
        {
            var sut = new FizzBuzz();
            Assert.Equal(expected,sut.PrintNumbers(10).ToArray());
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void ShouldTestCustomizedFizzBuzzResults(int max, List<string> values, List<(string word, int divisor)> configValues)
        {
            var sut = new FizzBuzz(configValues.ToArray());
            Assert.Equal(values, sut.PrintNumbers(max));
        }

        public static IEnumerable<object[]> GetTestData =>
            new List<object[]>
            {
                new object[] {10, new List<string> {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"},
                    new List<(string word, int divisor)> {(word: "Fizz", divisor: 3), (word: "Buzz", divisor: 5)}},
                new object[] {10, new List<string> {"1", "Foo", "Bar", "Foo", "5", "FooBar", "7", "Foo", "Bar", "Foo"},
                    new List<(string word, int divisor)> {(word: "Foo", divisor: 2), (word: "Bar", divisor: 3)}},
            };
    }
}
