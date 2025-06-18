public static class TwoSum_II
{
    public static int[] execute(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                return [left + 1, right + 1];
            }
            else
            {
                if (numbers[left] + numbers[right] > target)
                {
                    right = right - 1;
                }
                else
                {
                    left = left + 1;
                }
            }
        }
        return [];
    }
}
