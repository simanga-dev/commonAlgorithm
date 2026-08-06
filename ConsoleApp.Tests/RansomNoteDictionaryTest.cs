public class RansomNoteDictionaryTest
{
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    [InlineData("abc", "abc", true)]
    [InlineData("abc", "cba", true)]
    public void CanConstruct_ReturnsExpected(string ransomNote, string magazine, bool expected)
    {
        Assert.Equal(expected, RansomNoteDictionary.CanConstruct(ransomNote, magazine));
    }

    [Fact]
    public void CanConstruct_ReturnsTrue_ForEmptyRansomNote()
    {
        // An empty ransom note can always be constructed
        Assert.True(RansomNoteDictionary.CanConstruct("", "abc"));
    }

    [Fact]
    public void CanConstruct_ReturnsFalse_WhenMagazineIsEmpty()
    {
        Assert.False(RansomNoteDictionary.CanConstruct("a", ""));
    }

    [Fact]
    public void CanConstruct_ReturnsFalse_WhenInsufficientCharacterCount()
    {
        // Need two 'a's but magazine only has one
        Assert.False(RansomNoteDictionary.CanConstruct("aa", "a"));
    }
}
