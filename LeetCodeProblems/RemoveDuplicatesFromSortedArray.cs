namespace LeetCodeProblems
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int Solve(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            var size = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[size - 1] < nums[i])
                {
                    nums[size] = nums[i];
                    size++;
                }
            }

            return size;
        }
    }
}