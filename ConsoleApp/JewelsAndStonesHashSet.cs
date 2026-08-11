/// <summary>
/// Jewels and Stones (HashSet)
/// 
/// You're given strings <c>jewels</c> representing the types of stones that are
/// jewels, and <c>stones</c> representing the stones you have. Each character in
/// <c>stones</c> is a type of stone you have. You want to know how many of the
/// stones you have are also jewels.
/// 
/// Letters are case sensitive, so "a" is considered a different type of stone
/// from "A".
/// 
/// Constraints:
///   1 &lt;= jewels.Length, stones.Length &lt;= 50
///   jewels and stones consist of only English letters.
///   All the characters of jewels are unique.
/// 
/// Examples:
///   jewels = "aA", stones = "aAAbbbb" → 3
///   jewels = "z",  stones = "ZZ"      → 0
/// </summary>
public static class JewelsAndStonesHashSet
{
    public static int NumJewelsInStones(string jewels, string stones)
    {
        // TODO: Implement using HashSet&lt;char&gt; to store jewel types.
        // Hint: Load jewels into a HashSet, then count how many chars in stones are in the set.
        throw new NotImplementedException();
    }
}
