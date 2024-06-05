using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        if (shiftKey == 0 || shiftKey == 26)
            return text;

        StringBuilder result = new StringBuilder();
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char shiftedChar = ShiftCharacter(c, shiftKey);
                result.Append(shiftedChar);
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
    private static char ShiftCharacter(char c, int shiftKey)
    {
        char baseChar = char.IsLower(c) ? 'a' : 'A';
        return (char)(((c - baseChar + shiftKey) % 26) + baseChar);
    }
}
