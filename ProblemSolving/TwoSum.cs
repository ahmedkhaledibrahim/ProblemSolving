public static class TwoSum
{
    public static int[] Execute(int[] nums, int target)
    {
        Dictionary<int, int> occurences = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!occurences.ContainsKey(target - nums[i]))
            {
                occurences[nums[i]] = i;
            }
            else
            {
                return [occurences[target - nums[i]], i];
            }

        }
        return [];  
    }
}