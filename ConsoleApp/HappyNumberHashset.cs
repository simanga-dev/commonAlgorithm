/// <summary>
/// Happy Number (HashSet)
/// 
/// Write an algorithm to determine if a number n is happy.
/// 
/// A happy number is defined by the following process:
/// Starting with any positive integer, replace the number by the sum of the
/// squares of its digits, and repeat the process until the number equals 1
/// (happy), or it loops endlessly in a cycle that does not include 1 (not happy).
/// 
/// Return true if n is a happy number, false otherwise.
/// 
/// Examples:
///   n = 19 → true  (1²+9²=82, 8²+2²=68, 6²+8²=100, 1²+0²+0²=1)
///   n = 2  → false (2→4→16→37→58→89→145→42→20→4→... cycle)
/// </summary>
public static class HappyNumberHashset
{
    public static bool IsHappy(int n)
    {
        // TODO: Implement using a HashSet<int> to detect cycles.
        // Hint: Compute sum of squares of digits; if it repeats (in the set),
        //       a cycle is found → return false. If sum reaches 1, return true.
        throw new NotImplementedException();
    }
}
