public class RemoveAllAdjacentDuplicatesStackTest
{
    [Theory]
    [InlineData("abbaca", "ca")]
    [InlineData("azxxzy", "ay")]
    [InlineData("a", "a")]
    [InlineData("aa", "")]
    [InlineData("abba", "")]
    public void RemoveDuplicates_ReturnsExpected(string input, string expected)
    {
        Assert.Equal(expected, RemoveAllAdjacentDuplicatesStack.RemoveDuplicates(input));
    }

    [Fact]
    public void RemoveDuplicates_ReturnsEmpty_WhenEmptyInput()
    {
        Assert.Equal("", RemoveAllAdjacentDuplicatesStack.RemoveDuplicates(""));
    }

    [Fact]
    public void RemoveDuplicates_ReturnsSame_WhenNoDuplicates()
    {
        Assert.Equal("abcde", RemoveAllAdjacentDuplicatesStack.RemoveDuplicates("abcde"));
    }

    [Fact]
    public void RemoveDuplicates_HandlesAllSameChars()
    {
        // "aaaa" → "" (all pairs cancel out)
        Assert.Equal("", RemoveAllAdjacentDuplicatesStack.RemoveDuplicates("aaaa"));
    }

    [Fact]
    public void RemoveDuplicates_HandlesNestedRemovals()
    {
        // "abccba" → "abba" → "aa" → ""
        Assert.Equal("", RemoveAllAdjacentDuplicatesStack.RemoveDuplicates("abccba"));
    }
}
