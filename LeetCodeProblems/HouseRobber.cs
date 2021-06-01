using System;

namespace LeetCodeProblems
{
    public class HouseRobber
    {
        int[] sums;
        public int Solve(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            sums = new int[nums.Length];
            sums[0] = nums[0];
            sums[1] = Math.Max(sums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                sums[i] = Math.Max(sums[i - 1], sums[i - 2] + nums[i]);
            }
            return sums[sums.Length - 1];
        }
    }
}
