public class GroupAnagramsDictionaryTest
{
    [Fact]
    public void GroupAnagrams_ReturnsCorrectGroups_ForMixedStrings()
    {
        string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result = GroupAnagramsDictionary.GroupAnagrams(input);

        Assert.Equal(3, result.Count);

        // Sort each inner group and the outer list for deterministic comparison
        var sorted = result.Select(g => g.OrderBy(x => x).ToList())
                          .OrderBy(g => g[0])
                          .ToList();

        Assert.Contains(sorted, g => g.SequenceEqual(new List<string> { "ate", "eat", "tea" }));
        Assert.Contains(sorted, g => g.SequenceEqual(new List<string> { "bat" }));
        Assert.Contains(sorted, g => g.SequenceEqual(new List<string> { "nat", "tan" }));
    }

    [Fact]
    public void GroupAnagrams_ReturnsSingleGroup_WhenAllAreAnagrams()
    {
        string[] input = { "abc", "bca", "cab" };
        var result = GroupAnagramsDictionary.GroupAnagrams(input);

        Assert.Single(result);
        Assert.Equal(3, result[0].Count);
    }

    [Fact]
    public void GroupAnagrams_ReturnsEmptyList_ForEmptyInput()
    {
        var result = GroupAnagramsDictionary.GroupAnagrams(Array.Empty<string>());
        Assert.Empty(result);
    }

    [Fact]
    public void GroupAnagrams_ReturnsSingleElementGroups_WhenNoAnagrams()
    {
        string[] input = { "cat", "dog", "bird" };
        var result = GroupAnagramsDictionary.GroupAnagrams(input);

        Assert.Equal(3, result.Count);
        Assert.All(result, g => Assert.Single(g));
    }
}
