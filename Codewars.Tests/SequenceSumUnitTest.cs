namespace Codewars.Tests
{
    using Codewars.SumOfNum0toN;

    using Xunit;

    public class SequenceSumTests
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal("0+1+2+3+4+5+6 = 21", SequenceSum.ShowSequence(6));
        }
    }
}
