public static class GroupAnagrams
{
    public static IList<IList<string>> exeucte(string[] strs)
    {
        Dictionary<string, IList<string>> anagrams = new Dictionary<string, IList<string>>();
        foreach (var word in strs)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            string sortedWord = new string(wordChars);
            if (!anagrams.ContainsKey(sortedWord))
            {
                anagrams.Add(sortedWord, [word]);
            }
            else
            {
                anagrams[sortedWord].Add(word);
            }
        }
        return anagrams.Select(kv => kv.Value).ToList();
    }
}