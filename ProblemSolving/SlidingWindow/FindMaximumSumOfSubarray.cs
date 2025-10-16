using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.SlidingWindow
{
    public static class FindMaximumSumOfSubarray
    {
        public static int Execute(int[] arr, int k) {
            int maximum = 0;
            int windowSum = 0;
            for (int i = 0; i < k; i++)
            {
                maximum += arr[i];
            }
            windowSum = maximum;

            for (int i = 0; i < arr.Length - k; i++)
            {
                windowSum = windowSum - arr[i] + arr[k + i];
                maximum = Math.Max(maximum, windowSum);
            }
            return maximum;
        }
    }
}
