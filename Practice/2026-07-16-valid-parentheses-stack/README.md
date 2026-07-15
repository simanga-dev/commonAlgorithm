# 2026-07-16: Valid Parentheses using Stack

        Topic: Stack

        C# standard library focus: `Stack<char>`

        ## Problem

        Return true when every opening bracket has the correct closing bracket in the correct order. Supported brackets are (), [], and {}.

        ## Your task

        Implement `ValidParenthesesStack.IsValid(string text)` in `ConsoleApp/ValidParenthesesStack.cs`.

        The tests are in `ConsoleApp.Tests/ValidParenthesesStackTest.cs`.

        Run this while solving:

        ```bash
        DOTNET_ROLL_FORWARD=Major dotnet test --filter ValidParenthesesStackTest
        ```

        ## Hints

        1. Push opening brackets onto a Stack<char>.
2. When you see a closing bracket, the stack must not be empty.
3. Pop and compare that it matches the closing bracket.

        ## Habit rule

        Start simple. Make the tests pass first. After that, improve readability if needed.
