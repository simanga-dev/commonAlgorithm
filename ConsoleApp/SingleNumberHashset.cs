/// <summary>
/// Single Number (HashSet)
/// 
/// Given a non-empty array of integers nums, every element appears twice
/// except for one. Find that single one.
/// 
/// You must implement a solution with linear runtime complexity and use
/// a HashSet to track seen elements.
/// 
/// Constraints:
///   1 &lt;= nums.Length &lt;= 3 * 10^4
///   -3 * 10^4 &lt;= nums[i] &lt;= 3 * 10^4
///   Each element appears exactly twice, except for one element which appears once.
/// 
/// Examples:
///   [2,2,1] → 1
///   [4,1,2,1,2] → 4
///   [1] → 1
/// </summary>
public static class SingleNumberHashset
{
    public static int FindSingleNumber(int[] nums)
    {
        // TODO: Implement using HashSet&lt;int&gt; to track seen numbers.
        // Hint: Add to set on first encounter; remove on second. The one left is the answer.
        throw new NotImplementedException();
    }
}
