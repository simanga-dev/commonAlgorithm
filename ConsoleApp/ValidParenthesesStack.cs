public static class ValidParenthesesStack
{
    public static bool IsValid(string text)
    {
        var brackets = new Stack<char>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(' || text[i] == '[' || text[i] == '{')
            {
                brackets.Push(text[i]);
            }
            else if (text[i] == ')' || text[i] == ']' || text[i] == '}')
            {
                if (brackets.Count == 0)
                {
                    return false;
                }

                char openingBracket = brackets.Pop();

                if ((text[i] == ')' && openingBracket != '(') ||
                    (text[i] == ']' && openingBracket != '[') ||
                    (text[i] == '}' && openingBracket != '{'))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return brackets.Count == 0;
    }
}
