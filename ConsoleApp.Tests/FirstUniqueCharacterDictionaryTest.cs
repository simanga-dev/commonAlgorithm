public class FirstUniqueCharacterDictionaryTest
{
    [Theory]
    [InlineData("leetcode", 0)]
    [InlineData("loveleetcode", 2)]
    [InlineData("aabb", -1)]
    [InlineData("", -1)]
    public void FirstUniqueIndex_ReturnsFirstUniqueCharacterIndex(string text, int expected)
    {
        Assert.Equal(expected, FirstUniqueCharacterDictionary.FirstUniqueIndex(text));
    }
}
