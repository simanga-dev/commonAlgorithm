public class TopKFrequentElementsDictionaryTest
{
    [Fact]
    public void TopKFrequent_StandardCase_ReturnsTopK()
    {
        int[] nums = [1, 1, 1, 2, 2, 3];
        int k = 2;
        int[] result = TopKFrequentElementsDictionary.TopKFrequent(nums, k);
        Assert.Equal(2, result.Length);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
    }

    [Fact]
    public void TopKFrequent_SingleElement_ReturnsThatElement()
    {
        int[] nums = [1];
        int k = 1;
        int[] result = TopKFrequentElementsDictionary.TopKFrequent(nums, k);
        Assert.Equal([1], result);
    }

    [Fact]
    public void TopKFrequent_AllSameFrequency_ReturnsAnyK()
    {
        int[] nums = [5, 5, 3, 3, 7, 7];
        int k = 2;
        int[] result = TopKFrequentElementsDictionary.TopKFrequent(nums, k);
        Assert.Equal(2, result.Length);
    }

    [Fact]
    public void TopKFrequent_KEqualsArrayLength_ReturnsAllElements()
    {
        int[] nums = [1, 2, 3, 4];
        int k = 4;
        int[] result = TopKFrequentElementsDictionary.TopKFrequent(nums, k);
        Assert.Equal(4, result.Length);
    }

    [Fact]
    public void TopKFrequent_NegativeNumbers_HandlesCorrectly()
    {
        int[] nums = [-1, -1, -2, -2, -2, -3];
        int k = 2;
        int[] result = TopKFrequentElementsDictionary.TopKFrequent(nums, k);
        Assert.Equal(2, result.Length);
        Assert.Contains(-2, result);
        Assert.Contains(-1, result);
    }

    [Fact]
    public void TopKFrequent_LargeFrequencies_ReturnsCorrect()
    {
        int[] nums = [10, 10, 10, 20, 20, 30];
        int k = 1;
        int[] result = TopKFrequentElementsDictionary.TopKFrequent(nums, k);
        Assert.Equal([10], result);
    }
}
