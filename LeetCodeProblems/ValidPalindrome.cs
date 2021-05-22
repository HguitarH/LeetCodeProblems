namespace LeetCodeProblems
{
    public class ValidPalindrome
    {
        public bool Solve(string s)
        {
            string s_new = "";
            foreach (var c in s)
            {
                if (('a' <= c && c <= 'z') || ('0' <= c && c <= '9'))
                    s_new += c;
                else if ('A' <= c && c <= 'Z')
                    s_new += (char)(c - 'A' + 'a');
            }
            for (int i = 0; i < s_new.Length / 2; i++)
                if (s_new[i] != s_new[s_new.Length - 1 - i])
                    return false;

            return true;
        }
    }
}