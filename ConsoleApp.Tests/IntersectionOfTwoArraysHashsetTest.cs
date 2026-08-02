public class IntersectionOfTwoArraysHashsetTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2 })]
    [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 9, 4 })]
    public void Intersection_ReturnsCommonElements(int[] nums1, int[] nums2, int[] expected)
    {
        var result = IntersectionOfTwoArraysHashset.Intersection(nums1, nums2);
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Intersection_ReturnsEmpty_WhenNoCommonElements()
    {
        var result = IntersectionOfTwoArraysHashset.Intersection(
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 });
        Assert.Empty(result);
    }

    [Fact]
    public void Intersection_ReturnsAll_WhenArraysAreIdentical()
    {
        var result = IntersectionOfTwoArraysHashset.Intersection(
            new int[] { 1, 2, 3 },
            new int[] { 1, 2, 3 });
        Assert.Equal(new int[] { 1, 2, 3 }.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Intersection_ReturnsEmpty_WhenFirstArrayEmpty()
    {
        var result = IntersectionOfTwoArraysHashset.Intersection(
            new int[] { },
            new int[] { 1, 2, 3 });
        Assert.Empty(result);
    }

    [Fact]
    public void Intersection_ReturnsEmpty_WhenSecondArrayEmpty()
    {
        var result = IntersectionOfTwoArraysHashset.Intersection(
            new int[] { 1, 2, 3 },
            new int[] { });
        Assert.Empty(result);
    }

    [Fact]
    public void Intersection_ReturnsEmpty_WhenBothArraysEmpty()
    {
        var result = IntersectionOfTwoArraysHashset.Intersection(
            new int[] { },
            new int[] { });
        Assert.Empty(result);
    }
}
