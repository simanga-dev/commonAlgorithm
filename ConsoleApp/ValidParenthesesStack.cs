using System.Collections;

public static class ValidParenthesesStack
{
    public static bool IsValid(string text)
    {
        var p = new Stack();

        for (int i = 0; i < text.Length; i++)
        {
            p.Push(text[i]);

        }
        return false;
    }
}
