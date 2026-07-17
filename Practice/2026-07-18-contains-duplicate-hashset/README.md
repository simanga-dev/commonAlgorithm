# 2026-07-18: Contains Duplicate using HashSet

        Topic: Arrays + HashSet<T>

        C# standard library focus: `HashSet<int>`

        ## Problem

        Return true if any number appears at least twice. Return false when every number is unique.

        ## Your task

        Implement `ContainsDuplicateHashSet.HasDuplicate(int[] numbers)` in `ConsoleApp/ContainsDuplicateHashSet.cs`.

        The tests are in `ConsoleApp.Tests/ContainsDuplicateHashSetTest.cs`.

        Run this while solving:

        ```bash
        DOTNET_ROLL_FORWARD=Major dotnet test --filter ContainsDuplicateHashSetTest
        ```

        ## Hints

        1. Create a HashSet<int> for numbers you have seen.
2. HashSet.Add returns false when the item already exists.
3. You can return early as soon as you find a duplicate.

        ## Habit rule

        Start simple. Make the tests pass first. After that, improve readability if needed.
