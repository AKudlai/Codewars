namespace Codewars.Tests
{
    using System;

    using Codewars.ReverseOrRotate;

    using Xunit;

    public class ReverseOrRotate
    {
        [Fact]
        public void CanRevertRot()
        {
            // Arrange
            Console.WriteLine("Testing RevRot");
            Testing(Revrot.RevRot("1234", 0), string.Empty);
            Testing(Revrot.RevRot(string.Empty, 0), string.Empty);
            Testing(Revrot.RevRot("1234", 5), string.Empty);
            string s = "733049910872815764";
            Testing(Revrot.RevRot(s, 5), "330479108928157");
        }

        private static void Testing(string actual, string expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}
