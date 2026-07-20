# Review: Contains Duplicate using HashSet

## Test result summary

✅ `dotnet test --filter ContainsDuplicateHashSetTest` passed.

- Failed: 0
- Passed: 4
- Skipped: 0
- Total: 4

## Correctness notes

Nice work — the solution correctly returns `true` as soon as it finds a repeated number, and returns `false` when the loop finishes without finding any duplicates.

The core logic is sound:

```csharp
HashSet<int> s = [];

for (int i = 0; i < numbers.Length; i++)
{
    if (s.Contains(numbers[i]))
    {
        return true;
    }
    else
    {
        s.Add(numbers[i]);
    }
}

return false;
```

This handles empty arrays, single-item arrays, arrays with no duplicates, and arrays where a duplicate appears early or late.

## C# standard-library / data-structure lesson

`HashSet<T>` is a great fit for this problem because it stores unique values and gives average-case `O(1)` lookup and insertion.

Your solution uses two operations:

- `Contains(value)` to check whether the value has already been seen
- `Add(value)` to remember a new value

A small C# improvement: `HashSet<T>.Add` already tells you whether the value was newly added. It returns `false` if the item was already present. That means this can be simplified to one hash-set lookup per number:

```csharp
HashSet<int> seen = [];

foreach (int number in numbers)
{
    if (!seen.Add(number))
    {
        return true;
    }
}

return false;
```

Both versions are correct, but using `Add` directly is a common and useful `HashSet` pattern.

## Readability notes

The code is easy to follow and uses early return well. A couple of readability tweaks would make it even clearer:

- Prefer a descriptive variable name like `seen` instead of `s`.
- The `else` is not necessary after a `return`; removing it reduces nesting.
- A `foreach` loop works nicely here because the index is not used except to access the current value.

## Concrete next steps

1. Refactor this solution using `seen.Add(number)` so you practice the standard `HashSet` duplicate-detection pattern.
2. Use a descriptive collection name such as `seen` or `visited`.
3. Try explaining the time and space complexity out loud: average `O(n)` time and `O(n)` extra space.
