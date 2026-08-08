public class SingleNumberHashsetTest
{
    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { -1, -1, -2 }, -2)]
    [InlineData(new int[] { 0, 0, 5 }, 5)]
    public void FindSingleNumber_ReturnsSingleElement(int[] nums, int expected)
    {
        Assert.Equal(expected, SingleNumberHashset.FindSingleNumber(nums));
    }

    [Fact]
    public void FindSingleNumber_HandlesLargerArray()
    {
        // All numbers appear twice except 99
        int[] nums = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 99 };
        Assert.Equal(99, SingleNumberHashset.FindSingleNumber(nums));
    }

    [Fact]
    public void FindSingleNumber_HandlesNegativeAndPositiveMix()
    {
        int[] nums = { -5, 10, -5 };
        Assert.Equal(10, SingleNumberHashset.FindSingleNumber(nums));
    }
}
