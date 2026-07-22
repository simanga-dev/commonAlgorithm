public static class FirstUniqueCharacterDictionary
{
    public static int FirstUniqueIndex(string text)
    {
        Dictionary<char, int> counts = [];

        // First pass: count occurrences of each character
        foreach (char c in text)
        {
            counts[c] = counts.GetValueOrDefault(c) + 1;
        }

        // Second pass: return the first index whose character appears once
        for (int i = 0; i < text.Length; i++)
        {
            if (counts[text[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}
