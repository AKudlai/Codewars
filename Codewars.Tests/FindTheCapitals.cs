namespace Codewars.Tests
{
    using System;

    using Codewars.FindTheCapitals;
    using Xunit;

    public class FindTheCapitalsTest
    {
        [Fact]
        public void CanFindTheCapitals()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(FindTheCapitals.Capitals("CodEWaRs"), new[] { 0, 3, 4, 6 });
            Assert.Equal(FindTheCapitals.Capitals(string.Empty), new int[0]);
            Assert.Equal(FindTheCapitals.Capitals("CodEWaRs and CodEWaRs"), new[] { 0, 3, 4, 6, 13, 16, 17, 19 });
        }

        [Fact]
        public void CanFindTheCapitalsLinq()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(FindTheCapitals.CapitalsLinq("CodEWaRs"), new[] { 0, 3, 4, 6 });
            Assert.Equal(FindTheCapitals.CapitalsLinq(string.Empty), new int[0]);
            Assert.Equal(FindTheCapitals.CapitalsLinq("CodEWaRs and CodEWaRs"), new[] { 0, 3, 4, 6, 13, 16, 17, 19 });
        }
    }
}
