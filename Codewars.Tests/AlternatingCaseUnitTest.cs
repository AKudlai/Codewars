namespace Codewars.Tests
{
    using Codewars.AlternatingCase;

    using Xunit;

    public class AlternatingCaseUnitTest
    {
        [Fact]
        public void CanAlternateCase()
        {
            // Arrange
            const string S1 = "hello world";
            const string S2 = "HELLO WORLD";
            const string S3 = "hello WORLD";
            const string S4 = "HeLLo WoRLD";
            const string S5 = "12345";
            const string S6 = "1a2b3c4d5e";
            const string S7 = "String.ToAlternatingCase";
            const string S8 = "Hello World";


            // Act


            // Assert
            Assert.Equal("HELLO WORLD", S1.ToAlternatingCase());
            Assert.Equal("hello world", S2.ToAlternatingCase());
            Assert.Equal("HELLO world", S3.ToAlternatingCase());
            Assert.Equal("hEllO wOrld", S4.ToAlternatingCase());
            Assert.Equal("12345", S5.ToAlternatingCase());
            Assert.Equal("1A2B3C4D5E", S6.ToAlternatingCase());
            Assert.Equal("sTRING.tOaLTERNATINGcASE", S7.ToAlternatingCase());
            Assert.Equal("Hello World", S8.ToAlternatingCase().ToAlternatingCase());
        }
    }
}
