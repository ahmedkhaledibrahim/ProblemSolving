using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.SlidingWindow
{
    public static class FindMaximumAverageOfSubarray
    {
        public static double Execute(int[] arr, int k)
        {
            double maximum = 0;
            double windowSum = 0;
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
            return maximum / k;

        }
    }
}
