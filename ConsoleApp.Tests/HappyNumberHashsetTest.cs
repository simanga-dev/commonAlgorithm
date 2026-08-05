public class HappyNumberHashsetTest
{
    [Theory]
    [InlineData(19, true)]
    [InlineData(1, true)]
    [InlineData(7, true)]
    [InlineData(10, true)]
    [InlineData(100, true)]
    [InlineData(2, false)]
    [InlineData(3, false)]
    [InlineData(4, false)]
    [InlineData(5, false)]
    public void IsHappy_ReturnsExpected(int n, bool expected)
    {
        Assert.Equal(expected, HappyNumberHashset.IsHappy(n));
    }

    [Fact]
    public void IsHappy_ReturnsFalse_ForKnownUnhappyNumber()
    {
        // n=2 enters the standard unhappy cycle
        Assert.False(HappyNumberHashset.IsHappy(2));
    }

    [Fact]
    public void IsHappy_ReturnsTrue_ForLargeHappyNumber()
    {
        // 986543210 is happy
        Assert.True(HappyNumberHashset.IsHappy(986543210));
    }
}
