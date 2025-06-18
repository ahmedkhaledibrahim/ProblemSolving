using System.Text.RegularExpressions;

public static class ValidPalindrome
{
    public static bool execute(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }
        string cleanedString = s.Replace(" ", "").ToLower();
        cleanedString = Regex.Replace(cleanedString, "[^a-zA-Z0-9]", "");
        for (int i = 0; i < cleanedString.Length/2; i++)
        {
            if (cleanedString[i] != cleanedString[cleanedString.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}