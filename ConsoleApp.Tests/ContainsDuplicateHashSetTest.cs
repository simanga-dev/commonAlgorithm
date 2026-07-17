public class ContainsDuplicateHashSetTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    [InlineData(new int[] { }, false)]
    public void HasDuplicate_DetectsRepeatedValues(int[] numbers, bool expected)
    {
        Assert.Equal(expected, ContainsDuplicateHashSet.HasDuplicate(numbers));
    }
}
