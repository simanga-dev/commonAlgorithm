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
        var warmerDays = new int[temperatures.Length];
        var unresolvedDays = new Stack<int>();

        for (var currentDay = 0; currentDay < temperatures.Length; currentDay++)
        {
            while (unresolvedDays.Count > 0 &&
                   temperatures[currentDay] > temperatures[unresolvedDays.Peek()])
            {
                var colderDay = unresolvedDays.Pop();
                warmerDays[colderDay] = currentDay - colderDay;
            }

            unresolvedDays.Push(currentDay);
        }

        return warmerDays;
    }
}
