public class ValidParenthesesStackTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("([{}])", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("(", false)]
    public void IsValid_ChecksBracketOrder(string text, bool expected)
    {
        Assert.Equal(expected, ValidParenthesesStack.IsValid(text));
    }
}
