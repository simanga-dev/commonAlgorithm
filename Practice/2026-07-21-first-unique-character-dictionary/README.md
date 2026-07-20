# 2026-07-21: First Unique Character using Dictionary

        Topic: Strings + Dictionary<TKey,TValue>

        C# standard library focus: `Dictionary<char, int>`

        ## Problem

        Return the index of the first character that appears exactly once. Return -1 when no unique character exists.

        ## Your task

        Implement `FirstUniqueCharacterDictionary.FirstUniqueIndex(string text)` in `ConsoleApp/FirstUniqueCharacterDictionary.cs`.

        The tests are in `ConsoleApp.Tests/FirstUniqueCharacterDictionaryTest.cs`.

        Run this while solving:

        ```bash
        DOTNET_ROLL_FORWARD=Major dotnet test --filter FirstUniqueCharacterDictionaryTest
        ```

        ## Hints

        1. First pass: count each character with Dictionary<char, int>.
2. Second pass: return the first index where the count is 1.
3. Be careful with empty strings.

        ## Habit rule

        Start simple. Make the tests pass first. After that, improve readability if needed.
