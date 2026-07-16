public class PrimeNumbe2Test
{

    PrimeNumbers primeNumber = new();

    [Theory]
    //[InlineData(4, true)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(11, true)]
    [InlineData(43, true)]
    [InlineData(97, true)]
    [InlineData(100, false)]
    public void CheckPrime(int input, bool output)
    {
        Assert.Equal(primeNumber.CheckPrime(input), output);
    }
}
