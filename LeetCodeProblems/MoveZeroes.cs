namespace LeetCodeProblems
{
    public class MoveZeroes
    {
        public void Solve(int[] nums)
        {
            var zeros = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeros++;
                }
                else if (zeros > 0)
                {
                    nums[i - zeros] = nums[i];
                    nums[i] = 0;
                }
            }
        }
    }
}