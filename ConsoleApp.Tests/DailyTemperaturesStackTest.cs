public class DailyTemperaturesStackTest
{
    [Theory]
    [InlineData(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new int[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
    [InlineData(new int[] { 30, 40, 50, 60 }, new int[] { 1, 1, 1, 0 })]
    [InlineData(new int[] { 30, 60, 90 }, new int[] { 1, 1, 0 })]
    public void GetWarmerDays_ReturnsCorrectWaitDays(int[] temperatures, int[] expected)
    {
        Assert.Equal(expected, DailyTemperaturesStack.GetWarmerDays(temperatures));
    }

    [Fact]
    public void GetWarmerDays_ReturnsZeroArray_WhenSingleElement()
    {
        Assert.Equal(new int[] { 0 }, DailyTemperaturesStack.GetWarmerDays(new int[] { 50 }));
    }

    [Fact]
    public void GetWarmerDays_ReturnsZeroArray_WhenAllDecreasing()
    {
        Assert.Equal(new int[] { 0, 0, 0, 0 }, DailyTemperaturesStack.GetWarmerDays(new int[] { 90, 80, 70, 60 }));
    }

    [Fact]
    public void GetWarmerDays_ReturnsEmptyArray_WhenEmptyInput()
    {
        Assert.Empty(DailyTemperaturesStack.GetWarmerDays(new int[] { }));
    }
}
