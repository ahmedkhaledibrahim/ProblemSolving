public static class ValidAnagram
{
    public static bool execute(string t, string s)
    {
        if (t.Count() != s.Count() || string.IsNullOrEmpty(t) || string.IsNullOrEmpty(s))
        {
            return false;
        }

        Dictionary<char, int> CountT = new Dictionary<char, int>();
        Dictionary<char, int> CountS = new Dictionary<char, int>();

        for (int i = 0; i < t.Count(); i++)
        {
            CountT[t[i]] = 1 + CountT.GetValueOrDefault(t[i], 0);
            CountS[s[i]] = 1 + CountS.GetValueOrDefault(s[i], 0);
        }

        for (int i = 0; i < t.Count(); i++)
        {
            if (CountT.GetValueOrDefault(t[i], 0) != CountS.GetValueOrDefault(t[i], 0))
            {
                return false;
            }
        }
        return true;
    }
}