using Xunit;

public class WordPatternDictionaryTest
{
    [Theory]
    [InlineData("abba", "dog cat cat dog", true)]
    [InlineData("abba", "dog cat cat fish", false)]
    [InlineData("aaaa", "dog cat cat dog", false)]
    [InlineData("abba", "dog dog dog dog", false)]
    [InlineData("a", "dog", true)]
    public void WordPattern_ValidInputs_ReturnsExpected(string pattern, string s, bool expected)
    {
        bool result = WordPatternDictionary.WordPattern(pattern, s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordPattern_EmptyPatternAndEmptyString_ReturnsTrue()
    {
        bool result = WordPatternDictionary.WordPattern("", "");
        Assert.True(result);
    }

    [Fact]
    public void WordPattern_PatternLongerThanWords_ReturnsFalse()
    {
        bool result = WordPatternDictionary.WordPattern("abba", "dog cat");
        Assert.False(result);
    }

    [Fact]
    public void WordPattern_WordsLongerThanPattern_ReturnsFalse()
    {
        bool result = WordPatternDictionary.WordPattern("ab", "dog cat fish");
        Assert.False(result);
    }

    [Theory]
    [InlineData("abc", "dog cat dog", false)]
    [InlineData("abc", "dog cat fish", true)]
    public void WordPattern_ThreeDistinctChars(string pattern, string s, bool expected)
    {
        bool result = WordPatternDictionary.WordPattern(pattern, s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordPattern_SameWordDifferentChars_ReturnsFalse()
    {
        // 'a' -> "dog", 'b' -> "dog" — violates bijection
        bool result = WordPatternDictionary.WordPattern("ab", "dog dog");
        Assert.False(result);
    }
}
