public class ValidAnagramDictionaryTest
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("listen", "silent", true)]
    [InlineData("hello", "world", false)]
    public void IsAnagram_ReturnsExpected(string s, string t, bool expected)
    {
        Assert.Equal(expected, ValidAnagramDictionary.IsAnagram(s, t));
    }

    [Fact]
    public void IsAnagram_ReturnsTrue_WhenBothEmpty()
    {
        Assert.True(ValidAnagramDictionary.IsAnagram("", ""));
    }

    [Fact]
    public void IsAnagram_ReturnsFalse_WhenDifferentLengths()
    {
        Assert.False(ValidAnagramDictionary.IsAnagram("abc", "abcd"));
    }

    [Fact]
    public void IsAnagram_ReturnsTrue_WhenSingleCharSame()
    {
        Assert.True(ValidAnagramDictionary.IsAnagram("a", "a"));
    }

    [Fact]
    public void IsAnagram_ReturnsFalse_WhenSingleCharDifferent()
    {
        Assert.False(ValidAnagramDictionary.IsAnagram("a", "b"));
    }

    [Fact]
    public void IsAnagram_ReturnsTrue_WhenAllSameChars()
    {
        Assert.True(ValidAnagramDictionary.IsAnagram("aaaa", "aaaa"));
    }

    [Fact]
    public void IsAnagram_ReturnsFalse_WhenSameCharsButDifferentCounts()
    {
        Assert.False(ValidAnagramDictionary.IsAnagram("aaab", "aabb"));
    }
}
