public class MinStackTest
{
    [Fact]
    public void GetMin_ReturnsMinimum_AfterMultiplePushes()
    {
        var stack = new MinStack();
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);

        Assert.Equal(-3, stack.GetMin()); // min is -3
    }

    [Fact]
    public void GetMin_ReturnsCorrectMin_AfterPop()
    {
        var stack = new MinStack();
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);
        stack.Pop();

        Assert.Equal(0, stack.Top());    // top is 0 after pop
        Assert.Equal(-2, stack.GetMin()); // min reverts to -2
    }

    [Fact]
    public void Top_ReturnsLastPushedElement()
    {
        var stack = new MinStack();
        stack.Push(1);
        stack.Push(2);

        Assert.Equal(2, stack.Top());
    }

    [Fact]
    public void GetMin_WithDuplicateMinimums_HandlesCorrectly()
    {
        var stack = new MinStack();
        stack.Push(2);
        stack.Push(0);
        stack.Push(3);
        stack.Push(0);

        Assert.Equal(0, stack.GetMin());
        stack.Pop();
        Assert.Equal(0, stack.GetMin());
        stack.Pop();
        Assert.Equal(0, stack.GetMin());
        stack.Pop();
        Assert.Equal(2, stack.GetMin());
    }

    [Fact]
    public void PushPop_TopAndGetMin_SingleElement()
    {
        var stack = new MinStack();
        stack.Push(42);

        Assert.Equal(42, stack.Top());
        Assert.Equal(42, stack.GetMin());
        stack.Pop();
        // Stack is empty now — Pop and Top/GetMin on empty stack
        // (we don't test GetMin on empty as it's undefined per LeetCode constraints)
    }

    [Fact]
    public void Push_WithNegativeAndPositiveValues_TracksMin()
    {
        var stack = new MinStack();
        stack.Push(5);
        Assert.Equal(5, stack.GetMin());

        stack.Push(-1);
        Assert.Equal(-1, stack.GetMin());

        stack.Push(10);
        Assert.Equal(-1, stack.GetMin());
    }
}
