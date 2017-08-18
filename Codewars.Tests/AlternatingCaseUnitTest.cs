namespace Codewars.Tests
{
    using Codewars.AlternatingCase;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CanAlternateCase()
        {
            // Arrange
            string s1 = "hello world";
            string s2 = "HELLO WORLD";
            string s3 = "hello WORLD";
            string s4 = "HeLLo WoRLD";
            string s5 = "12345";
            string s6 = "1a2b3c4d5e";
            string s7 = "String.ToAlternatingCase";
            string s8 = "Hello World";


            // Act


            // Assert
            Assert.AreEqual("HELLO WORLD", s1.ToAlternatingCase());
            Assert.AreEqual("hello world", s2.ToAlternatingCase());
            Assert.AreEqual("HELLO world", s3.ToAlternatingCase());
            Assert.AreEqual("hEllO wOrld", s4.ToAlternatingCase());
            Assert.AreEqual("12345", s5.ToAlternatingCase());
            Assert.AreEqual("1A2B3C4D5E", s6.ToAlternatingCase());
            Assert.AreEqual("sTRING.tOaLTERNATINGcASE", s7.ToAlternatingCase());
            Assert.AreEqual("Hello World", s8.ToAlternatingCase().ToAlternatingCase(), "Hello World => hELLO wORLD => Hello World");
        }
    }
}
