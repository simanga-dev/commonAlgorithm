public class EvaluateReversePolishNotationStackTest
{
    [Theory]
    [InlineData(new string[] { "2", "1", "+", "3", "*" }, 9)]
    [InlineData(new string[] { "4", "13", "5", "/", "+" }, 6)]
    [InlineData(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
    public void EvalRPN_ReturnsExpected(string[] tokens, int expected)
    {
        Assert.Equal(expected, EvaluateReversePolishNotationStack.EvalRPN(tokens));
    }

    [Fact]
    public void EvalRPN_ReturnsValue_ForSingleOperand()
    {
        Assert.Equal(42, EvaluateReversePolishNotationStack.EvalRPN(new string[] { "42" }));
    }

    [Fact]
    public void EvalRPN_HandlesDivisionTruncationTowardZero()
    {
        // 13 / 5 = 2 (truncated toward zero)
        Assert.Equal(2, EvaluateReversePolishNotationStack.EvalRPN(new string[] { "13", "5", "/" }));
    }

    [Fact]
    public void EvalRPN_HandlesNegativeDivision()
    {
        // -7 / 2 = -3 (truncated toward zero)
        Assert.Equal(-3, EvaluateReversePolishNotationStack.EvalRPN(new string[] { "-7", "2", "/" }));
    }

    [Fact]
    public void EvalRPN_HandlesNegativeOperands()
    {
        Assert.Equal(-13, EvaluateReversePolishNotationStack.EvalRPN(new string[] { "-10", "-3", "+" }));
    }

    [Fact]
    public void EvalRPN_HandlesSubtractionWithNegativeResult()
    {
        Assert.Equal(-4, EvaluateReversePolishNotationStack.EvalRPN(new string[] { "3", "7", "-" }));
    }
}
