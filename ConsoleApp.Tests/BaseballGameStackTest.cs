public class BaseballGameStackTest
{
    [Theory]
    [InlineData(new string[] { "5", "2", "C", "D", "+" }, 30)]
    [InlineData(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)]
    [InlineData(new string[] { "1", "C" }, 0)]
    public void CalPoints_ReturnsExpectedSum(string[] ops, int expected)
    {
        Assert.Equal(expected, BaseballGameStack.CalPoints(ops));
    }

    [Fact]
    public void CalPoints_HandlesSingleScore()
    {
        Assert.Equal(42, BaseballGameStack.CalPoints(new string[] { "42" }));
    }

    [Fact]
    public void CalPoints_HandlesAllPositiveScores()
    {
        Assert.Equal(12, BaseballGameStack.CalPoints(new string[] { "3", "4", "5" }));
    }

    [Fact]
    public void CalPoints_HandlesAllDoubleOperations()
    {
        // 5 → [5]; D → [5,10]; D → [5,10,20] => 35
        Assert.Equal(35, BaseballGameStack.CalPoints(new string[] { "5", "D", "D" }));
    }

    [Fact]
    public void CalPoints_HandlesAllSumOperations()
    {
        // 1 → [1]; 2 → [1,2]; + → [1,2,3]; + → [1,2,3,5] => 11
        Assert.Equal(11, BaseballGameStack.CalPoints(new string[] { "1", "2", "+", "+" }));
    }
}
