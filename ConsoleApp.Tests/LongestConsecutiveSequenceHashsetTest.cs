public class LongestConsecutiveSequenceHashsetTest
{
    [Fact]
    public void LongestConsecutive_StandardCase_ReturnsCorrectLength()
    {
        int[] nums = [100, 4, 200, 1, 3, 2];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(4, result); // [1,2,3,4]
    }

    [Fact]
    public void LongestConsecutive_EmptyArray_ReturnsZero()
    {
        int[] nums = [];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void LongestConsecutive_SingleElement_ReturnsOne()
    {
        int[] nums = [5];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void LongestConsecutive_Duplicates_CountedOnce()
    {
        int[] nums = [1, 2, 2, 3, 3, 3];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(3, result); // [1,2,3]
    }

    [Fact]
    public void LongestConsecutive_NoConsecutive_ReturnsOne()
    {
        int[] nums = [1, 3, 5, 7, 9];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void LongestConsecutive_NegativeNumbers_HandlesCorrectly()
    {
        int[] nums = [-3, -2, -1, 0, 1];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(5, result); // [-3,-2,-1,0,1]
    }

    [Fact]
    public void LongestConsecutive_AllConsecutive_ReturnsLength()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(7, result);
    }

    [Fact]
    public void LongestConsecutive_UnorderedWithGaps_ReturnsLongestRun()
    {
        int[] nums = [10, 5, 12, 3, 55, 30, 4, 11, 2];
        int result = LongestConsecutiveSequenceHashset.LongestConsecutive(nums);
        Assert.Equal(4, result); // [2,3,4,5]
    }
}
