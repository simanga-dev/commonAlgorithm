/// <summary>
/// Given a pattern and a string s, determine if s follows the same pattern.
/// Here "follow" means a full match, such that there is a bijection between
/// a letter in pattern and a non-empty word in s.
///
/// Example 1:
///   pattern = "abba", s = "dog cat cat dog" → true
///   Explanation: 'a' maps to "dog", 'b' maps to "cat"
///
/// Example 2:
///   pattern = "abba", s = "dog cat cat fish" → false
///   Explanation: 'a' maps to "dog", but then 'a' would need to map to "fish"
///
/// Example 3:
///   pattern = "aaaa", s = "dog cat cat dog" → false
///   Explanation: 'a' maps to "dog" but then to "cat"
///
/// Example 4:
///   pattern = "abba", s = "dog dog dog dog" → false
///   Explanation: 'a' maps to "dog", 'b' also maps to "dog" (bijection violated)
/// </summary>
public static class WordPatternDictionary
{
    public static bool WordPattern(string pattern, string s)
    {
        // TODO: Implement using Dictionary<char, string> and HashSet<string>.
        // Hint: Map each char to a word while tracking used words in a HashSet to enforce bijection.
        throw new NotImplementedException();
    }
}
