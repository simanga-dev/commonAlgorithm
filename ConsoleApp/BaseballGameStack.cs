/// <summary>
/// Baseball Game (Stack)
/// 
/// You are keeping score for a baseball game with strange rules.
/// At the beginning, you start with an empty record. You are given a list of
/// strings operations where each operation is one of:
///   - An integer x: Record a new score of x.
///   - "+": Record a new score that is the sum of the previous two scores.
///   - "D": Record a new score that is double the previous score.
///   - "C": Invalidate the previous score, removing it from the record.
/// 
/// Return the sum of all the scores on the record after applying all operations.
/// 
/// Constraints:
///   1 &lt;= operations.Length &lt;= 1000
///   operations[i] is "C", "D", "+", or a string representing an integer in range [-3 * 10^4, 3 * 10^4]
///   For "+", there will always be at least two previous scores.
///   For "D" and "C", there will always be at least one previous score.
/// 
/// Examples:
///   ["5","2","C","D","+"] → 30  (5, 2; C removes 2; D doubles 5→10; + sums 5+10→15; total: 5+10+15=30)
///   ["5","-2","4","C","D","9","+","+"] → 27
///   ["1","C"] → 0
/// </summary>
public static class BaseballGameStack
{
    public static int CalPoints(string[] operations)
    {
        // TODO: Implement using Stack&lt;int&gt; to track scores.
        // Hint: Push scores; for "+" peek last two and push sum; for "D" peek last and push double; for "C" pop.
        throw new NotImplementedException();
    }
}
