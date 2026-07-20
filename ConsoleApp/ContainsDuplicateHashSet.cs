public static class ContainsDuplicateHashSet
{
    public static bool HasDuplicate(int[] numbers)
    {
        HashSet<int> s = [];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (s.Contains(numbers[i]))
            {
                return true;
            }
            else
            {
                s.Add(numbers[i]);
            }
        }

        return false;
    }
}
