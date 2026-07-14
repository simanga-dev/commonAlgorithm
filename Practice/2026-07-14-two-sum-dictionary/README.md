# 2026-07-14: Two Sum using Dictionary

        Topic: Arrays + Dictionary<TKey,TValue>

        C# standard library focus: `Dictionary<int, int>`

        ## Problem

        Return the indices of two different numbers that add up to target. Return an empty array when no pair exists.

        ## Your task

        Implement `TwoSumDictionary.FindTwoSum(int[] numbers, int target)` in `ConsoleApp/TwoSumDictionary.cs`.

        The tests are in `ConsoleApp.Tests/TwoSumDictionaryTest.cs`.

        Run this while solving:

        ```bash
        DOTNET_ROLL_FORWARD=Major dotnet test --filter TwoSumDictionaryTest
        ```

        ## Hints

        1. Loop through the array once.
2. For each value, calculate the complement: target - value.
3. Use Dictionary<int, int> to remember values you already saw and their index.

        ## Habit rule

        Start simple. Make the tests pass first. After that, improve readability if needed.
