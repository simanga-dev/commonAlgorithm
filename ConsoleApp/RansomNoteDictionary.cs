/// <summary>
/// Ransom Note (Dictionary)
/// 
/// Given two strings ransomNote and magazine, return true if ransomNote can be
/// constructed by using the letters from magazine and false otherwise.
/// 
/// Each letter in magazine can only be used once in ransomNote.
/// 
/// Constraints:
///   1 &lt;= ransomNote.Length, magazine.Length &lt;= 10^5
///   ransomNote and magazine consist of lowercase English letters.
/// 
/// Examples:
///   ransomNote = "a", magazine = "b"    → false
///   ransomNote = "aa", magazine = "ab"  → false
///   ransomNote = "aa", magazine = "aab" → true
/// </summary>
public static class RansomNoteDictionary
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        // TODO: Implement using Dictionary&lt;char, int&gt; to count character frequencies.
        // Hint: Count chars in magazine, then decrement for each char in ransomNote.
        throw new NotImplementedException();
    }
}
