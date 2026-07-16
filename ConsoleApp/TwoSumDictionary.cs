public static class TwoSumDictionary
{
    public static int[] FindTwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 1; j < numbers.Length; j++)
                if ((numbers[i] + numbers[j]) == target)
                    return [i, j];
        }
        return [];
    }
}
