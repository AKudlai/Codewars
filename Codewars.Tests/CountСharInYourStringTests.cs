using System.Collections.Generic;

using Codewars.CountСharInYourString;

using Xunit;

public class Tests
{
    [Fact]
    public static void FixedTestAaaa()
    {
        Dictionary<char, int> d = new Dictionary<char, int>();
        d.Add('a', 4);
        Assert.Equal(d, Kata.Count("aaaa"));
    }

    [Fact]
    public static void FixedTestAabb()
    {
        Dictionary<char, int> d = new Dictionary<char, int>();
        d.Add('a', 2);
        d.Add('b', 2);
        Assert.Equal(d, Kata.Count("aabb"));
    }
}