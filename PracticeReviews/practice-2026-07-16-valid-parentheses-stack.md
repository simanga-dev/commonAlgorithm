# Review: Valid Parentheses using Stack

Branch: `practice/2026-07-16-valid-parentheses-stack`

## Test result summary

✅ `dotnet test --filter ValidParenthesesStackTest` passed.

Result: 6 passed, 0 failed.

## Correctness notes

Nice work using `Stack<char>` for the bracket-matching problem. The solution correctly:

- Pushes opening brackets onto the stack.
- Returns `false` when a closing bracket appears with no matching opener.
- Pops the most recent opener and checks that it matches the current closer.
- Returns `false` for mismatched nesting like `([)]`.
- Confirms the stack is empty at the end, which catches leftover open brackets like `((`.

One important repo-habit note: this diff also includes unrelated changes/files from an earlier Two Sum exercise and a commented-out Prime Number test case. Try to keep each practice branch focused on only the current problem so reviews stay clean and accidental test changes do not hide bugs.

## C# standard-library / data-structure lesson

`Stack<T>` is the right data structure here because bracket validation is a **last-in, first-out** problem:

- The most recently opened bracket must be the first one closed.
- `Push` stores an opener.
- `Pop` retrieves and removes the most recent opener.
- `Count` lets you safely check whether the stack is empty before popping.

That pattern is common for parsing, undo history, expression validation, and depth-first traversal.

## Readability notes

The code is clear and beginner-friendly. A small improvement for later would be reducing repeated bracket checks by using a helper method or a dictionary mapping closing brackets to opening brackets, for example `')' -> '('`. That is not required here, but it can make the matching logic easier to extend.

Also, since the method only needs characters, a `foreach (char c in text)` loop would read slightly more directly than indexing with `text[i]`.

## Concrete next steps

1. Keep this solution approach: `Stack<char>` is exactly the right tool for the problem.
2. On future practice branches, avoid modifying unrelated tests or adding files from previous exercises.
3. As an optional refactor, try replacing the repeated `if` conditions with a `Dictionary<char, char>` for closing-to-opening bracket pairs.
