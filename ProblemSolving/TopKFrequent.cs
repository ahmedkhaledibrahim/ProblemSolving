public static class TopKFrequent
{

    public static int[] execute(int[] nums, int k)
    {
        Dictionary<int, int> occurrences = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!occurrences.ContainsKey(num))
            {
                occurrences[num] = 0;
            }
            else
            {
                occurrences[num] = occurrences[num] + 1;
            }
        }
        var pq = new PriorityQueue<int, int>();
        foreach (var item in occurrences)
        {
            pq.Enqueue(item.Key, item.Value);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }
        return result;
    }
}