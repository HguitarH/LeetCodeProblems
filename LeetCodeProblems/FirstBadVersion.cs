namespace LeetCodeProblems
{
    public class FirstBadVersion
    {
        // given API
        private bool IsBadVersion(int _) => true;


        public int Solve(int n)
        {
            int left = 1;
            int right = n;

            while (left < right)
            {
                int p = right / 2 + left / 2;
                if (IsBadVersion(p))
                    right = p;
                else
                    left = p + 1;
            }

            return left;
        }
    }
}