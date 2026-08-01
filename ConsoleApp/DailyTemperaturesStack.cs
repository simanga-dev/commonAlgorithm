/// <summary>
/// Daily Temperatures (Stack)
/// 
/// Given an array of integers representing daily temperatures, return an array where
/// answer[i] is the number of days you have to wait after the i-th day to get a warmer
/// temperature. If no warmer day exists, answer[i] = 0.
/// 
/// Examples:
///   [73,74,75,71,69,72,76,73] → [1,1,4,2,1,1,0,0]
///   [30,40,50,60]            → [1,1,1,0]
///   [30,60,90]               → [1,1,0]
/// </summary>
public static class DailyTemperaturesStack
{
    public static int[] GetWarmerDays(int[] temperatures)
    {
        // TODO: Implement using a Stack to track indices of unresolved colder days.
        // Hint: iterate through the array and use a monotonic decreasing stack; when
        // a warmer day is found, pop and compute the difference for all colder days.
        throw new NotImplementedException();
    }
}
