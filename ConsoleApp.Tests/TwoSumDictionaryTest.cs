public class TwoSumDictionaryTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void FindTwoSum_ReturnsIndices(int[] numbers, int target, int[] expected)
    {
        Assert.Equal(expected, TwoSumDictionary.FindTwoSum(numbers, target));
    }

    [Fact]
    public void FindTwoSum_ReturnsEmptyArray_WhenNoPairExists()
    {
        Assert.Empty(TwoSumDictionary.FindTwoSum(new int[] { 1, 2, 3 }, 10));
    }
}
