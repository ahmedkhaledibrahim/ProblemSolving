public static class ContainsDuplicate
{
    public static bool execute(int[] nums)
    {
        Dictionary<int, int> existingNums = [];
        foreach (int item in nums)
        {
            if (existingNums.ContainsKey(item))
            {
                return true;
            }
            else
            {
                existingNums.Add(item, 1);
            }
        }
        return false;
    }
}