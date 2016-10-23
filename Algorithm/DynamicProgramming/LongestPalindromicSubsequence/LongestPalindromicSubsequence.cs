namespace Algorithm.DynamicProgramming.LongestPalindromicSubsequence
{
    public class LongestPalindromicSubsequence
    {
        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        private static int Lps(string input, int n)
        {
            int[,] l = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                l[i, i] = 1;
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j <  n - i + 1; j++)
                {
                    var k = j + i - 1;
                    if (input[j] == input[k] && i == 2)
                        l[j,k] = 2;
                    else if (input[j] == input[k])
                        l[j,k] = l[j + 1,k - 1] + 2;
                    else
                        l[j,k] = Max(l[j,k - 1], l[j + 1,k]);
                }
            }
            return l[0, n - 1];
        }

        public static int Main(string input)
        {
            int n = input.Length;
            return Lps(input, n);
        }
    }
}
