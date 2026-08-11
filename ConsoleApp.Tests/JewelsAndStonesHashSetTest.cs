public class JewelsAndStonesHashSetTest
{
    [Theory]
    [InlineData("aA", "aAAbbbb", 3)]
    [InlineData("z", "ZZ", 0)]
    [InlineData("abc", "abcabc", 6)]
    public void NumJewelsInStones_ReturnsExpectedCount(string jewels, string stones, int expected)
    {
        Assert.Equal(expected, JewelsAndStonesHashSet.NumJewelsInStones(jewels, stones));
    }

    [Fact]
    public void NumJewelsInStones_EmptyJewels_ReturnsZero()
    {
        Assert.Equal(0, JewelsAndStonesHashSet.NumJewelsInStones("", "abc"));
    }

    [Fact]
    public void NumJewelsInStones_EmptyStones_ReturnsZero()
    {
        Assert.Equal(0, JewelsAndStonesHashSet.NumJewelsInStones("aA", ""));
    }

    [Fact]
    public void NumJewelsInStones_EmptyBoth_ReturnsZero()
    {
        Assert.Equal(0, JewelsAndStonesHashSet.NumJewelsInStones("", ""));
    }

    [Fact]
    public void NumJewelsInStones_NoMatch_ReturnsZero()
    {
        Assert.Equal(0, JewelsAndStonesHashSet.NumJewelsInStones("xyz", "abc"));
    }

    [Fact]
    public void NumJewelsInStones_CaseSensitive()
    {
        // 'a' and 'A' are different
        Assert.Equal(1, JewelsAndStonesHashSet.NumJewelsInStones("a", "aA"));
    }

    [Fact]
    public void NumJewelsInStones_AllJewels()
    {
        // Every stone is a jewel
        Assert.Equal(5, JewelsAndStonesHashSet.NumJewelsInStones("AB", "ABABA"));
    }
}
