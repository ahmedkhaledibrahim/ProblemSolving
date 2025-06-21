public static class ThreeSum{
    public static IList<IList<int>> execute(int[] nums)
    {
        IList<IList<int>> result = [];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i != 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] + nums[i] == 0)
                {
                    result.Add([nums[left], nums[right], nums[i]]);
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left + 1])
                    {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right - 1])
                    {
                        right--;
                    }
                }
                else if (nums[left] + nums[right] > (0 - nums[i]))
                {
                    right--;
                }
                else if (nums[left] + nums[right] < (0 - nums[i]))
                {
                    left++;
                }
            }

        }
        return result;
    }
}