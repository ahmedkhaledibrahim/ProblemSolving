public static class LongestConsecutiveSequence
{
    public static int execute(int[] nums)
    {
        HashSet<int> numsSet = [.. nums];
        int result = 0;
        foreach (var item in nums)
        {
            if (!numsSet.Contains(item - 1))
            {
                int current = item;
                int streak = 1;
                while (numsSet.Contains(current + 1))
                {
                    numsSet.Remove(current);
                    current++;
                    streak++;
                }
                result = int.Max(streak, result);
            }
        }
        return result;
    }
}