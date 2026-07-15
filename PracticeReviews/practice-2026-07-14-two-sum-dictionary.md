# Review: Two Sum Dictionary

Branch: `practice/2026-07-14-two-sum-dictionary`

## Test result summary

✅ `dotnet test --filter TwoSumDictionaryTest` passed.

- Failed: 0
- Passed: 4
- Skipped: 0
- Total: 4

Nice work getting the current test suite green.

## Correctness notes

Your solution finds a pair by checking combinations of indexes and returning the first pair whose values add up to the target. For the current tests, that is enough.

One important edge case to watch for: the inner loop starts at `j = 1`, so it can compare an element with itself when `i == j`. For example, index `1` could be used twice if `numbers[1] + numbers[1] == target`. In Two Sum, the two answers should usually be two different indexes.

A safer nested-loop version would start the inner loop at `i + 1`:

```csharp
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] + numbers[j] == target)
            return [i, j];
    }
}
```

## C# standard-library / data-structure lesson

The practice goal for this problem was to use `Dictionary<int, int>`. A dictionary lets you solve Two Sum in one pass by remembering numbers you have already seen.

The idea is:

1. For each number, compute the complement: `target - numbers[i]`.
2. Check whether that complement already exists in the dictionary.
3. If it exists, return the stored index and the current index.
4. Otherwise, store the current number and index.

Example shape:

```csharp
var seen = new Dictionary<int, int>();

for (int i = 0; i < numbers.Length; i++)
{
    int complement = target - numbers[i];

    if (seen.TryGetValue(complement, out int previousIndex))
        return [previousIndex, i];

    seen[numbers[i]] = i;
}

return [];
```

`TryGetValue` is useful because it checks for a key and retrieves the value in one lookup.

## Readability notes

- The code is short and easy to follow.
- Consider always using braces around `if` bodies, especially while practicing. It prevents bugs when adding more statements later.
- Returning `[]` for “not found” is clear in modern C#, but make sure that behavior matches the problem statement or tests.

## Concrete next steps

1. Rewrite this solution using `Dictionary<int, int>` to practice the intended data structure.
2. Add or think through a test where using the same index twice would be tempting, such as `[3]` with target `6` or `[1, 3, 5]` with target `6`.
3. Prefer `seen.TryGetValue(complement, out int index)` when doing dictionary lookups in C#.
